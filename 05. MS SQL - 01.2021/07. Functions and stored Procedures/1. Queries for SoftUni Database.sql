--1.	Employees with Salary Above 35000

CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
SELECT FirstName, LastName FROM Employees
WHERE Salary > 35000
GO

EXEC usp_GetEmployeesSalaryAbove35000

--2.	Employees with Salary Above Number

CREATE OR ALTER PROCEDURE usp_GetEmployeesSalaryAboveNumber @Number DECIMAL(18, 4)
AS
SELECT FirstName, LastName, Salary FROM Employees
WHERE Salary > @Number
ORDER BY Salary DESC
GO

EXEC usp_GetEmployeesSalaryAboveNumber 48100


--3.	Town Names Starting With

CREATE OR ALTER PROCEDURE usp_GetTownsStartingWith @String NVARCHAR(MAX)
AS
SELECT * FROM Towns
WHERE [Name] LIKE @String + '%'
GO

EXEC usp_GetTownsStartingWith s

--4.	Employees from Town

GO

CREATE OR ALTER PROCEDURE usp_GetEmployeesFromTown @Town NVARCHAR(MAX)
AS
SELECT e.FirstName, e.LastName, e.Salary, a.AddressText, t.Name FROM Employees e
JOIN Addresses a
ON a.AddressID = e.AddressID
JOIN Towns t
ON t.TownID = a.TownID
WHERE t.Name = @Town
GO

EXEC usp_GetEmployeesFromTown Sofia

--5.	Salary Level Function

GO

CREATE OR ALTER FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @Level VARCHAR(7) = CASE
		WHEN @salary < 30000 THEN 'Low'
		WHEN @salary <= 50000 THEN 'Average'
		ELSE 'High'
	END
	RETURN @Level
END

GO

SELECT Salary, dbo.ufn_GetSalaryLevel(Salary) FROM Employees 

--6.	Employees by Salary Level

GO

CREATE OR ALTER PROC usp_EmployeesBySalaryLevel @SalaryLevel VARCHAR(7)
AS
	SELECT e.FirstName, e.LastName FROM Employees e
	WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @SalaryLevel 
GO

EXEC usp_EmployeesBySalaryLevel 'high'

--7.	Define Function

GO

CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(MAX), @word NVARCHAR(MAX)) 
RETURNS BIT
AS
BEGIN
	DECLARE @result INT = 0;
	DECLARE @i INT = 1;
	WHILE (@i <= LEN(@word))
	BEGIN
		IF(@setOfLetters LIKE '%' + SUBSTRING(@word, @i, 1) + '%')
		BEGIN
			SET @result = 1;
		END
		ELSE
		BEGIN
			SET @result = 0;
			BREAK;
		END

		SET @i += 1;
	END
	RETURN @result;
END

GO

SELECT dbo.ufn_IsWordComprised('oitssmiahf', 'Sofias')

--8.	* Delete Employees and Departments

GO

CREATE OR ALTER PROC usp_DeleteEmployeesFromDepartment (@departmentId INT) 
AS

UPDATE Employees
SET ManagerID = NULL
WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

ALTER TABLE Departments
ALTER COLUMN ManagerID INT NULL

UPDATE Departments
SET ManagerID = NULL
WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

DELETE FROM EmployeesProjects
WHERE EmployeeID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

DELETE FROM Employees
WHERE DepartmentID = @departmentId

DELETE FROM Departments
WHERE DepartmentID = @departmentId

SELECT COUNT(*) FROM Employees
WHERE DepartmentID = @departmentId

GO

EXEC dbo.usp_DeleteEmployeesFromDepartment 1

--10.	People with Balance Higher Than

USE Bank

GO

CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan (@minBalance DECIMAL(18,4))
AS
BEGIN
	SELECT FirstName, LastName FROM AccountHolders ah
	JOIN Accounts a ON ah.Id = a.AccountHolderId
	GROUP BY ah.FirstName, ah.LastName
	HAVING SUM(Balance) > @minBalance --To get the correct total balance of all accounts for one person!
	ORDER BY ah.FirstName, ah.LastName
END
GO

EXEC dbo.usp_GetHoldersWithBalanceHigherThan 10000

--11.	Future Value Function

GO

CREATE OR ALTER FUNCTION ufn_CalculateFutureValue (@InitialValue DECIMAL(18, 4), @InterestRate FLOAT, @Years INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN
	DECLARE @Result DECIMAL(18, 4)
	SET @Result = @InitialValue * (POWER(1 + @InterestRate, @Years))
	RETURN @Result
END

GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)

--12.	Calculating Interest

SELECT 
	ah.Id, 
	ah.FirstName, 
	ah.LastName, 
	a.Balance AS [Current Balance],
	(SELECT dbo.ufn_CalculateFutureValue(a.Balance, 0.1, 5)) AS [Balance in 5 years]
FROM AccountHolders ah
JOIN Accounts a ON ah.Id = a.AccountHolderId

--13.	*Scalar Function: Cash in User Games Odd Rows

GO

USE Diablo

GO

--Function that returns a Table!

CREATE OR ALTER FUNCTION ufn_CashInUsersGames (@GameName NVARCHAR(50))
RETURNS TABLE
AS
RETURN SELECT(
	SELECT SUM(Cash) AS SumCash 
	FROM(
		SELECT 
			g.Name,
			Cash,
			ROW_NUMBER() OVER(PARTITION BY g.Name ORDER BY ug.Cash DESC) AS RowNum	
		FROM UsersGames ug
		JOIN Games g
		ON g.Id = ug.GameId
		WHERE g.Name = @GameName) AS t
	WHERE RowNum % 2 <> 0) AS SumCash

GO

SELECT * FROM dbo.ufn_CashInUsersGames('Ablajeck')

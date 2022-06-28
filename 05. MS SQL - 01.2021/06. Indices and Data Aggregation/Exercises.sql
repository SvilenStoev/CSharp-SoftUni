--1. Records’ Count

USE Gringotts

SELECT COUNT(*) FROM WizzardDeposits 

--2. Longest Magic Wand

SELECT MAX(MagicWandSize) FROM WizzardDeposits

--3. Longest Magic Wand Per Deposit Groups

SELECT DepositGroup, MAX(MagicWandSize) AS [LongestMagicWand]
FROM WizzardDeposits
GROUP BY DepositGroup

--4. * Smallest Deposit Group Per Magic Wand Size

SELECT TOP(2) 
	DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

--6. Deposits Sum for Ollivander Family

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup


--7. Deposits Filter

SELECT * FROM
(SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup) AS T
WHERE TotalSum < 150000
ORDER BY TotalSum DESC

--8.  Deposit Charge

SELECT 
	DepositGroup, 
	MagicWandCreator,
	MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator

--9. Age Groups

SELECT 
	(CASE
   when Age <= 10 then '[0-10]'
   when Age BETWEEN 11 AND 20 then '[11-20]'
   when Age BETWEEN 21 AND 30 then '[21-30]'
   when Age BETWEEN 31 AND 40 then '[31-40]'
   when Age BETWEEN 41 AND 50 then '[41-50]'
   when Age BETWEEN 51 AND 60 then '[51-60]'
   when Age > 60 then '[60+]' END) AS AgeGroup,
	COUNT(*) AS WizardCount
FROM WizzardDeposits
GROUP BY CASE
   when Age <= 10 then '[0-10]'
   when Age BETWEEN 11 AND 20 then '[11-20]'
   when Age BETWEEN 21 AND 30 then '[21-30]'
   when Age BETWEEN 31 AND 40 then '[31-40]'
   when Age BETWEEN 41 AND 50 then '[41-50]'
   when Age BETWEEN 51 AND 60 then '[51-60]'
   when Age > 60 then '[60+]'
END
CREATE INDEX IN_Messaget_MsgPrice ON Messages (MsgPrice)

--12. * Rich Wizard, Poor Wizard

SELECT SUM([Difference]) AS SumDifference FROM
(SELECT 
	w1.FirstName AS [Host Wizard],
	w1.DepositAmount AS [Host Wizard Deposit],
	w2.FirstName AS [Guest Wizard],
	w2.DepositAmount AS [Guest Wizard Deposit],
	(w2.DepositAmount - w1.DepositAmount) AS [Difference]
FROM WizzardDeposits w1
JOIN WizzardDeposits w2 ON w1.Id = w2.Id + 1) AS T

--Тази задача може да се реши и с LEAD(FirstName) OVER(ORDER BY Id) AS [Guest Wizard]

--13. Departments Total Salaries

USE SoftUni

SELECT DepartmentID, SUM(Salary) FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

--14. Employees Minimum Salaries

SELECT DepartmentID, MIN(Salary) FROM Employees
WHERE DepartmentID IN (2, 5, 7) AND CONVERT(SMALLDATETIME, HireDate) >= CONVERT(SMALLDATETIME, '01-01-2000')
GROUP BY DepartmentID
ORDER BY DepartmentID


--17. Employees Count Salaries

SELECT COUNT(*) FROM Employees
WHERE ManagerID IS NULL

--18. *3rd Highest Salary

SELECT DepartmentID, Salary AS [ThirdHighestSalary] FROM
(SELECT 
	DepartmentID, 
	Salary,
	ROW_NUMBER() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS SalaryRank
FROM Employees) AS T
WHERE SalaryRank = 3
ORDER BY DepartmentID

--19. **Salary Challenge

SELECT TOP(10)
	e.FirstName, 
	e.LastName, 
	e.Salary, 
	e.DepartmentID,
	t.AverageSalary
FROM Employees e
JOIN (SELECT DepartmentID, AVG(Salary) AS AverageSalary from Employees GROUP BY DepartmentID) t
ON t.DepartmentID = e.DepartmentID
WHERE e.Salary > t.AverageSalary
ORDER BY DepartmentID
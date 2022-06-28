USE SoftUni

--Problem 1.	Find Names of All Employees by First Name

SELECT FirstName, LastName FROM Employees
WHERE FirstName LIKE 'SA%'

--Problem 2.	  Find Names of All employees by Last Name 

SELECT FirstName, LastName FROM Employees
WHERE LastName LIKE '%ei%'

--Problem 3.	Find First Names of All Employees

SELECT FirstName From Employees
WHERE DepartmentID IN (3, 10)
	AND HireDate BETWEEN CONVERT(smalldatetime,'1995')
	AND CONVERT(smalldatetime,'2005')


--Problem 4.	Find All Employees Except Engineers

SELECT FirstName, LastName, JobTitle From Employees
WHERE JobTitle NOT LIKE '%engineer%'

--Problem 5.	Find Towns with Name Length

SELECT * FROM Towns
WHERE Len(Name) IN (5,6)
ORDER BY Name ASC

--Problem 6.	 Find Towns Starting With

SELECT * FROM Towns
WHERE Name LIKE '[MKBE]%'
ORDER BY Name ASC

--Problem 7.	 Find Towns Not Starting With

SELECT * FROM Towns
WHERE Name LIKE '[^R,B,D]%'
ORDER BY Name ASC

--Problem 8.	Create View Employees Hired After 2000 Year

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName FROM Employees
WHERE HireDate >= '01.01.2000'

SELECT * FROM V_EmployeesHiredAfter2000

--Problem 9.	Length of Last Name

SELECT FirstName, LastName FROM Employees
WHERE Len(LastName) = 5 

--Problem 10. Rank Employees by Salary

SELECT 
	EmployeeID,
	FirstName,
	LastName,
	Salary,
	DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID ASC) AS Rank
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC

--Problem 11.	Find All Employees with Rank 2 *

SELECT * FROM
(SELECT 
	EmployeeID,
	FirstName,
	LastName,
	Salary,
	DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID ASC) AS Rank
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000) AS [Table]
WHERE Rank = 2
ORDER BY Salary DESC


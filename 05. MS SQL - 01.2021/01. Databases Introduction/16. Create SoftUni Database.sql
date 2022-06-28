--Problem 16.	Create SoftUni Database

CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Towns 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Addresses  
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	AddressText NVARCHAR(MAX),
	TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL
)

CREATE TABLE Departments  
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Employees   
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	MiddleName NVARCHAR(50),
	LastName NVARCHAR(50) NOT NULL,
	JobTitle NVARCHAR(50) NOT NULL,
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
	HireDate DATE  NOT NULL,
	Salary INT NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL
)

INSERT INTO Towns([Name]) VALUES
	('Sofia'),
	('Plovdiv'),
	('Varna'),
	('Burgas')

INSERT INTO Addresses VALUES
	('Shipka 5', 1),
	('Smurch 34', 1),
	('Krajmorska', 3),
	('Druga', 2)

INSERT INTO Departments VALUES
	('Software Development'),
	('Engineering'),
	('Quality Assurance'),
	('Sales'),
	('Marketing')

INSERT INTO Employees VALUES  
	('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 1, '01/01/2013', 3500, 1),
	('Peter', 'Petrov', 'Petrov', 'Senior Engineer', 2, '01/01/2013', 4000, 2),
	('Maria', 'Petrova', 'Ivanova', 'Intern', 3, '01/01/2013', 525.25, 3),
	('Georgi', 'Teziev', 'Ivanov', 'CEO', 4, '01/01/2013', 3000.00, 4),
	('Ivan', 'Ivanov', 'Ivanov', 'Intern', 5, '01/01/2013', 599.88, 4)

--Problem 19.	Basic Select All Fields
SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees

--Problem 20.	Basic Select All Fields and Order Them
SELECT * FROM Towns ORDER BY [Name] ASC
SELECT * FROM Departments ORDER BY [Name] ASC
SELECT * FROM Employees ORDER BY Salary DESC

--Problem 21.	Basic Select Some Fields
SELECT [Name] FROM Towns ORDER BY [Name] ASC
SELECT [Name] FROM Departments ORDER BY [Name] ASC
SELECT FIrstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC

--Problem 22.	Increase Employees Salary
UPDATE Employees SET Salary = Salary * 1.1
SELECT Salary FROM Employees

--Problem 23.	Decrease Tax Rate
USE Hotel
UPDATE Payments SET TaxRate = TaxRate - (TaxRate * 3/100)
SELECT TaxRate FROM Payments

--Problem 24.	Delete All Records
DELETE FROM Occupancies
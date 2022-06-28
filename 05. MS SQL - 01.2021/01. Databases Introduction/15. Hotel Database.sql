--Problem 15.	Hotel Database

CREATE DATABASE Hotel

USE Hotel

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50),
	Notes NVARCHAR(MAX)
)

CREATE TABLE Customers 
(
	AccountNumber NVARCHAR(20) NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(10) NOT NULL,
	EmergencyName NVARCHAR(50) NOT NULL,
	EmergencyNumber NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RoomStatus
(
	RoomStatus BIT,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RoomTypes 
(
	RoomType NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE BedTypes  
(
	BedType NVARCHAR(20) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Rooms   
(
	RoomNumber NVARCHAR(20) NOT NULL,
	RoomType  NVARCHAR(20) NOT NULL,
	BedType  NVARCHAR(20) NOT NULL,
	Rate REAL,
	RoomStatus BIT,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Payments
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATETIME,
	AccountNumber NVARCHAR(20) NOT NULL,
	FirstDateOccupied DATETIME,
	LastDateOccupied DATETIME,
	TotalDays INT,
	AmountCharged DECIMAL,
	TaxRate REAL NOT NULL,
	TaxAmount INT,
	PaymentTotal INT,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATETIME,
	AccountNumber INT,
	RoomNumber INT NOT NULL,
	RateApplied REAL,
	PhoneCharge NVARCHAR(10),
	Notes NVARCHAR(MAX)
)

INSERT INTO Employees VALUES
('Svilen', 'Stoev', 'Developer', NULL),
('Peter', 'Petrov', 'Accountant', NULL),
('Йордан', 'Иванов', 'Picolo', NULL)

INSERT INTO Customers VALUES
('Svilen', 'Stoev', 'Boss', 'Boss', 'Boss', 'Boss', NULL),
('Svilen', 'Stoev', 'Boss', 'Boss', 'Boss', 'Boss', NULL),
('Svilen', 'Stoev', 'Boss', 'Boss', 'Boss', 'Boss', NULL)

INSERT INTO RoomStatus VALUES
(0, NULL),
(0, NULL),
(0, NULL)

INSERT INTO BedTypes VALUES
(0, NULL),
(0, NULL),
(0, NULL)

INSERT INTO Rooms VALUES
('5', 'Apartment', 'DoubleBed', 9.5, 0, NULL),
('5', 'Apartment', 'DoubleBed', 9.5, 0, NULL),
('5', 'Apartment', 'DoubleBed', 9.5, 0, NULL)

INSERT INTO Payments VALUES
(2, '2020-12-06', '5', '2020-12-06', '2020-12-06', 0, 10, 20, 2, 12, NULL),
(2, '2020-12-06', '5', '2020-12-06', '2020-12-06', 0, 10, 20, 2, 12, NULL),
(2, '2020-12-06', '5', '2020-12-06', '2020-12-06', 0, 10, 20, 2, 12, NULL)

INSERT INTO Occupancies VALUES
(3, '2020-12-06', 1, 10, 5.8, '0254122', NULL),
(3, '2020-12-06', 1, 10, 5.8, '0254122', NULL),
(3, '2020-12-06', 1, 10, 5.8, '0254122', NULL)

--Output
SELECT * FROM Employees
SELECT * FROM Customers
SELECT * FROM RoomStatus
SELECT * FROM BedTypes
SELECT * FROM Rooms
SELECT * FROM Payments

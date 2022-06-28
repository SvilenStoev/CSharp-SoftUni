--Problem 14.	Car Rental Database

CREATE DATABASE CarRental

USE CarRental

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName NVARCHAR(50) NOT NULL,
	DailyRate REAL,
	WeeklyRate REAL,
	MonthlyRate REAL,
	WeekendRate REAL
)

CREATE TABLE Cars
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	PlateNumber NVARCHAR(50) NOT NULL,
	Manufacturer NVARCHAR(50) NOT NULL,
	Model NVARCHAR(50) NOT NULL,
	CarYear DATETIME,
	CategoryId INT FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
	Doors TINYINT,
	Picture NVARCHAR(MAX),
	Condition NVARCHAR(MAX),
	Available BIT NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Title NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	DriverLicenceNumber NVARCHAR(10) NOT NULL,
	FullName NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	City NVARCHAR(50),
	ZIPCode NVARCHAR(4),
	Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	EmployeeId INT FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
	CarId INT FOREIGN KEY (CarId) REFERENCES Cars(Id),
	TankLevel TINYINT NOT NULL,
	KilometrageStart INT NOT NULL,
	KilometrageEnd INT NOT NULL,
	TotalKilometrage INT NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	TotalDays INT NOT NULL,
	RateApplied REAL,
	TaxRate REAL,
	OrderStatus BIT NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories VALUES
('Sport Car', 8.8, 8.5, 7.9, 8),
('Regular Car', 8.8, 8.5, 7.9, 8),
('Offroad Car', 8.8, 8.5, 7.9, 8)

INSERT INTO Cars VALUES
('CB6556AT', 'Mercedess', 'GLC 500', '2018-12-10', 1, 4, 'SomeStupidPicture', 'Verry good', 0),
('CB6556AX', 'Range Rover', 'XL', '2018-05-10', 3, 4, 'SomeStupidPicture', 'Verry good', 0),
('CB5485AA', 'Opel', 'Astra J', '2011-12-10', 2, 4, 'SomeStupidPicture', 'Not bad', 0)

INSERT INTO Employees VALUES
('Svilen', 'Stoev', 'Accountant', NULL),
('Tedi', 'Savov', 'Junior Accountant', 'Some stupid notes'),
('Dimitar', 'Ivanov', 'CEO', NULL)

INSERT INTO Customers VALUES
('51454131', 'Ivan Ivanov', 'Nezabravka street', 'Sofia', '1000', NULL),
('41589645', 'Петър Йорданов', 'Смърч 34', 'София', '1000', NULL),
('85965897', 'Георги Георгиев', 'Цариградско шосе 361', 'София', '1000', NULL)

INSERT INTO RentalOrders VALUES
(1, 1, 1, 50, 10000, 11000, 1000, '2021-01-23', '2021-01-24', 1, 8.5, 8, 0, NULL),
(2, 2, 2, 40, 10000, 11000, 1000, '2021-01-23', '2021-01-24', 1, 8.5, 8, 0, NULL),
(3, 3, 3, 50, 100000, 110000, 10000, '2021-01-23', '2021-01-23', 1, 4.5, 4, 0, NULL)

--Output

SELECT * FROM Categories

SELECT * FROM Cars

SELECT * FROM Employees

SELECT * FROM Customers

SELECT * FROM RentalOrders


--Problem 1.	One-To-One Relationship

USE TableRelationsExercises

CREATE TABLE Passports
(
	PassportID INT PRIMARY KEY,
	PassportNumber CHAR(10) NOT NULL
)

CREATE TABLE Persons
(
	PersonID INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	Salary DECIMAL(18,2) NOT NULL,
	PassportID INT REFERENCES Passports(PassportID) NOT NULL UNIQUE
)

INSERT INTO Passports (PassportID, PassportNumber)  VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

INSERT INTO Persons VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101)

SELECT pe.FirstName, pa.PassportNumber FROM Persons pe
JOIN Passports pa ON pe.PassportID = pa.PassportID

--Problem 2.	One-To-Many Relationship

CREATE TABLE Manufacturers
(
	ManufacturerID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	EstablishedOn DATE NOT NULL
)

CREATE TABLE Models
(
	ModelID INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	ManufacturerID INT REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers ([Name], EstablishedOn) VALUES
('BMW', '07/03/1916'),
('Tesla', '01/01/2003'),
('Lada', '01/05/1966')

INSERT INTO Models (ModelID, [Name], ManufacturerID) VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3)

SELECT mo.Name, ma.Name, FORMAT(ma.EstablishedOn, 'MM/dd/yyyy') FROM Models mo
JOIN Manufacturers ma
ON ma.ManufacturerID = mo.ManufacturerID


--Problem 3.	Many-To-Many Relationship

CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL
)

CREATE TABLE StudentsExams
(
	StudentID INT REFERENCES Students(StudentID),
	ExamID INT REFERENCES Exams(ExamID)
	PRIMARY KEY (StudentID, ExamID)
)

INSERT INTO Exams VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')

INSERT INTO Students VALUES
('Mila'),
('Toni'),
('Ron')

INSERT INTO StudentsExams VALUES
(1,	101),
(1,	102),
(2,	101),
(3,	103),
(2,	102),
(2,	103)

SELECT s.Name, e.Name FROM StudentsExams se
JOIN Students s ON se.StudentID = s.StudentID
JOIN Exams e ON se.ExamID = e.ExamID

--Problem 4.	Self-Referencing 

CREATE TABLE Teachers
(
	TeacherID INT PRIMARY KEY NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	ManagerID INT REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers VALUES
(101, 'John', NULL),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105),
(105, 'Mark', 101),
(106, 'Greta', 101)

SELECT * FROM Teachers

--Problem 9.	*Peaks in Rila

USE Geography

SELECT m.MountainRange, p.PeakName, p.Elevation FROM Peaks p
JOIN Mountains m ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'

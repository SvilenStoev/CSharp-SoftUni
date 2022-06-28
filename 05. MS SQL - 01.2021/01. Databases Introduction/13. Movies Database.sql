--Problem 13.	Movies Database
CREATE DATABASE Movies

USE Movies

CREATE TABLE Directors
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Genres 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	CategoryName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Movies  
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY (DirectorId) REFERENCES Directors(Id),
	CopyrightYear DATETIME NOT NULL,
	[Length] TIME NOT NULL,
	GenreId INT FOREIGN KEY (GenreId) REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
	Rating REAL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors VALUES
('Svilen Stoev', 'Some Stupid Notes'),
('Peter Petrov', 'Some Stupid Notes'),
('Veselka Stoeva', 'Some Stupid Notes'),
('Teodora Stoeva', 'Some Stupid Notes'),
('Dimiter Sotirov', 'Some Stupid Notes')

INSERT INTO Genres VALUES
('Action', 'Some Stupid Notes'),
('Comedy', 'Some Stupid Notes'),
('Drama', 'Some Stupid Notes'),
('Horror', 'Some Stupid Notes'),
('Thriller', 'Some Stupid Notes')

INSERT INTO Categories VALUES
('Not allowed for under 12', 'Some Stupid Notes'),
('Not allowed for under 16', 'Some Stupid Notes'),
('Not allowed for under 18', 'Some Stupid Notes'),
('Not allowed for under 21', 'Some Stupid Notes'),
('Allowed for every age', 'Some Stupid Notes')

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length],	GenreId, CategoryId, Rating, Notes) VALUES
('Titanic', 1, '2020-12-06', '01:40', 1, 1, 8.9, 'Some Stupid Notes'),
('Titanic', 1, '2020-12-06', '01:40', 1, 1, 8.9, 'Some Stupid Notes'),
('Titanic', 1, '2020-12-06', '01:40', 1, 1, 8.9, 'Some Stupid Notes'),
('Titanic', 1, '2020-12-06', '01:40', 1, 1, 8.9, 'Some Stupid Notes'),
('Titanic', 1, '2020-12-06', '01:40', 1, 1, 8.9, 'Some Stupid Notes')

SELECT * FROM Movies

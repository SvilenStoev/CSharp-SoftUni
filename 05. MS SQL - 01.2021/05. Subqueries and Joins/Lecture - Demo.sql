SELECT *
FROM Employees, Addresses

CREATE TABLE Suits
(
	Id INT PRIMARY KEY IDENTITY,
	NAME NVARCHAR(5)
)

CREATE TABLE Types
(
	Id INT PRIMARY KEY IDENTITY,
	NAME NVARCHAR(5)
)

SELECT t.NAME + ' ' + s.NAME FROM Types t, Suits s
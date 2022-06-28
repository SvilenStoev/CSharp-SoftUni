CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(200) NOT NULL,
	Picture NVARCHAR(MAX),
	Height REAL,
	Gender BIT NOT NULL,
	Birthdate DATETIME NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People VALUES
('Svilen', 'SomePicture.pgj', 180.50, 0, '1993-12-06', 'Some Biography'),
('Pesho', 'SomePicture.pgj', 170.50, 0, '1993-12-06', 'Some Biography'),
('Gosho', 'SomePicture.pgj', 150.50, 0, '1993-12-06', 'Some Biography'),
('Dragan', 'SomePicture.pgj', 160.50, 0, '1993-12-06', 'Some Biography'),
('Stoyan', 'SomePicture.pgj', 190.50, 0, '1993-12-06', 'Some Biography')

SELECT * FROM People
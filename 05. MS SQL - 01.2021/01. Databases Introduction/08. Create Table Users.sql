CREATE TABLE Users
(
	Id BIGINT IDENTITY PRIMARY KEY,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture NVARCHAR(MAX),
	LastLoginTime DATETIME,
	IsDeleted BIT
)

ALTER  TABLE  Users WITH CHECK 
   ADD CONSTRAINT Username UNIQUE (Username)

INSERT INTO Users (Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
Values
('UserName1', 'Password1', 'SomeProfilePicturePath1', '2021-01-22', 0),
('UserName2', 'Password2', 'SomeProfilePicturePath2', '2021-01-22', 0),
('UserName3', 'Password3', 'SomeProfilePicturePath3', '2021-01-22', 0),
('UserName4', 'Password4', 'SomeProfilePicturePath4', '2021-01-22', 0),
('UserName5', 'Password4', 'SomeProfilePicturePath4', '2021-01-22', 0)

--Problem 9.	Change Primary Key
--Using SQL queries modify table Users from the previous task. 
--First remove current primary key then create new primary key that would be 
--the combination of fields Id and Username.

ALTER TABLE Users
DROP CONSTRAINT [CH_PasswordIsAtLeast5Symbols]

ALTER TABLE Users
ADD CONSTRAINT PK_IdUsername 
PRIMARY KEY (Id, [Username])

--Problem 10.	Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT [CH_PasswordIsAtLeast5Symbols] CHECK (LEN([Password]) >= 5)

--Problem 11.	Set Default Value of a Field
ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime DEFAULT GETDATE() FOR LastLoginTime

--Problem 12.	Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT [PK_IdUsername]

ALTER TABLE Users
ADD CONSTRAINT PK_Id
PRIMARY KEY (ID)

ALTER TABLE Users
ADD CONSTRAINT [CH_UsernameIsAtLeast3Symbols] CHECK (LEN([Username]) >= 3)

--Output
SELECT * FROM Users

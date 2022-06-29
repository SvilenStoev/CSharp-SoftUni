--TRIGGER UPDATE ACCOUNT => INSERT LOGS

USE Bank

CREATE TABLE AccountChanges
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	AccountId INT NOT NULL REFERENCES Accounts(Id),
	OldBalance MONEY NOT NULL,
	NewBalance MONEY NOT NULL,
	DateOfChange DATETIME NOT NULL
)

GO

CREATE OR ALTER TRIGGER tr_OnAccountChangeAddLogRecord
ON Accounts FOR UPDATE
AS
	INSERT AccountChanges (AccountId, OldBalance, NewBalance, DateOfChange)
	SELECT i.Id, d.Balance, i.Balance, GETDATE() FROM inserted i
	JOIN deleted d ON i.Id = d.Id
GO

--TRIGGER ON DELETE ACCOUNTHOLDER -> NO DELETE -> UPDATE IsDeleted

GO

CREATE OR ALTER TRIGGER tr_OnDeleteAccountHoldersSetIsDeleted
ON AccountHolders INSTEAD OF DELETE
AS
	UPDATE AccountHolders SET IsDeleted = 1
	WHERE Id IN (SELECT Id FROM deleted)
GO


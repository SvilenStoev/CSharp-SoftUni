--11

CREATE FUNCTION udf_AllUserCommits(@username VARCHAR(MAX))
RETURNS INT AS
BEGIN
	DECLARE @return_value INT = (SELECT COUNT(*)
FROM Users u
JOIN Commits c ON u.Id = c.ContributorId
WHERE u.Username = @username)
    RETURN @return_value
END

SELECT dbo.udf_AllUserCommits56('UnderSinduxrein')

SELECT * FROM Users

--12

SELECT * FROM Files

CREATE PROCEDURE usp_SearchForFiles(@fileExtension varchar(100))
AS
	SELECT Id, Name, (CONVERT(VARCHAR, Size) + 'KB') AS Size
	FROM Files
	WHERE Name LIKE '%'+@fileExtension
	ORDER BY Id ASC, Name ASC, Size DESC
GO

EXEC usp_SearchForFiles 'txt'

--5

SELECT Id ,[Message], RepositoryId, ContributorId FROM Commits
ORDER BY 
	Id ASC,
	[Message] ASC,
	RepositoryId ASC,
	ContributorId ASC

--6

SELECT Id, [Name], Size FROM Files
WHERE Size > 1000 AND [Name] LIKE '%html%'
ORDER BY Size DESC, Id ASC, [Name] ASC

--7

SELECT
	i.Id,
	(u.Username + ' : ' + i.Title) AS IssueAssignee
FROM Issues i
JOIN Users u ON i.AssigneeId = u.Id
ORDER BY 
	i.Id DESC,
	IssueAssignee ASC

--8

SELECT Id, [Name], (CONVERT(VARCHAR, Size) + 'KB') AS Size
FROM Files
WHERE Id NOT IN (SELECT ParentId FROM Files WHERE ParentId IS NOT NULL)
ORDER BY Id ASC, [Name] ASC, Size DESC

/*SELECT * --Id, [Name], (CONVERT(VARCHAR, Size) + 'KB') AS Size
FROM Files f
JOIN Files f2 ON f.ParentId = f2.Id 
ORDER BY f.Id ASC, f.[Name] ASC, f.Size DESC*/

--9

SELECT TOP(5) r.Id, r.[Name], COUNT(*) AS Commits
FROM RepositoriesContributors rs
JOIN Repositories r ON rs.RepositoryId = r.Id
JOIN Commits c ON c.RepositoryId = r.Id
GROUP BY r.Id, r.[Name]
ORDER BY Commits DESC, r.Id ASC, r.[Name] ASC 

--Задача 9 - Трябва селектирате TOP(5) Id, Name, COUNT(*) от RepositoriesContributors и да ги JOIN-ете с Repositories и Commits

--10

--Select all users which have commits. Select their username and average size of the file, which were uploaded by them. 
--Order the results by average upload size (descending) and by username (ascending).

SELECT 
	u.Username,
	AVG(f.Size) AS Size
FROM Files f
JOIN Commits c ON f.CommitId = c.Id
JOIN Users u ON c.ContributorId = u.Id
GROUP BY u.Username
ORDER BY Size DESC, u.Username ASC
INSERT INTO Files ([Name], Size, ParentId, CommitId) VALUES
('Trade.idk', 2598.0, 1, 1),
('menu.net', 9238.31, 2, 2),
('Administrate.soshy', 1246.93, 3, 3),
('Controller.php',	7353.15, 4, 4),
('Find.java', 9957.86, 5, 5),
('Controller.json', 14034.87, 3, 6),
('Operate.xix',	7662.92, 7, 7)

INSERT INTO Issues (Title, IssueStatus, RepositoryId, AssigneeId) VALUES
('Critical Problem with HomeController.cs file', 'open', 1, 4),
('Typo fix in Judge.html', 'open', 4, 3),
('Implement documentation for UsersService.cs', 'closed', 8, 2),
('Unreachable code in Index.cs', 'open', 9, 8)

--3

SELECT * FROM Issues
WHERE AssigneeId = 6

UPDATE Issues
SET IssueStatus = 'closed'
WHERE AssigneeId = 6

--4

SELECT * FROM Issues i
JOIN Repositories r ON i.RepositoryId = r.Id 
WHERE r.[Name] = 'Softuni-Teamwork'


SELECT * FROM RepositoriesContributors rc
JOIN Repositories r ON rc.RepositoryId = r.Id 
WHERE r.[Name] = 'Softuni-Teamwork'

DELETE i FROM Issues i
INNER JOIN Repositories r ON i.RepositoryId = r.Id 
WHERE r.[Name] = 'Softuni-Teamwork'

DELETE rc FROM RepositoriesContributors rc
JOIN Repositories r ON rc.RepositoryId = r.Id 
WHERE r.[Name] = 'Softuni-Teamwork'
USE Diablo

--Problem 14.	Games from 2011 and 2012 year

SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') FROM Games
WHERE DATEPART(YEAR, [Start]) BETWEEN 2011 AND 2012
ORDER BY Start, Name

--Problem 15.	 User Email Providers

SELECT 
	Username,
	SUBSTRING(Email, CHARINDEX('@', Email) + 1, Len(email) - CHARINDEX('@', email)) AS [Email Provider] 
FROM Users
ORDER BY [Email Provider] ASC, Username


--Problem 16.	 Get Users with IPAdress Like Pattern

SELECT 
	Username,
	IpAddress AS [IP Address]
FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY Username

--Problem 17.	 Show All Games with Duration and Part of the Day

SELECT 
	[Name] AS Game,
	Case
		WHEN DATEPART(hour, [Start]) BETWEEN 0 and 11 THEN 'Morning'
		WHEN DATEPART(hour, [Start]) BETWEEN 12 and 17 THEN 'Afternoon'
		ELSE 'Evening' END AS [Part of the Day],
	CASE 
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
		WHEN Duration > 6 THEN 'Long'
		WHEN Duration IS NULL THEN 'Extra Long' 
		END AS Duration
FROM Games
ORDER BY Game ASC, Duration ASC, [Part of the Day] ASC
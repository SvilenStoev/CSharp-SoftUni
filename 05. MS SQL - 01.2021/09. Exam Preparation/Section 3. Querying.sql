--5. EEE-Mails

SELECT 
	FirstName,
	LastName,
	FORMAT(BirthDate, 'MM-dd-yyyy') AS BirthDate,
	[Name] AS Hometown,
	Email
FROM Accounts a
JOIN Cities c ON a.CityId=c.Id
WHERE Email LIKE 'e%'
ORDER BY [NAME] ASC

--6. City Statistics
--Първи вариант:
SELECT [NAME] AS City, (SELECT COUNT(*) FROM Hotels h WHERE h.CityId = c.Id) AS Hotels
FROM Cities c
WHERE (SELECT COUNT(*) FROM Hotels h WHERE h.CityId = c.Id) > 0
ORDER BY 
	Hotels DESC,
	City

--Втори вариант:
SELECT c.Name AS City, COUNT(*) AS Hotels 
FROM Hotels h
JOIN Cities c ON h.CityId = c.Id
GROUP BY c.[NAME]
ORDER BY Hotels DESC, c.Name ASC

--7. Longest and Shortest Trips

--Find the longest and shortest trip for each account, in days. Filter the results to accounts with no middle name and trips, which are not cancelled (CancelDate is null).
--Order the results by Longest Trip days (descending), then by Shortest Trip (ascending).

SELECT 
	AccountId,
	FirstName + ' ' + LastName AS FullName,
	MAX(DATEDIFF(day, t.ArrivalDate, t.ReturnDate)) AS LongestTrip,
	MIN(DATEDIFF(day, t.ArrivalDate, t.ReturnDate)) AS ShortestTrip
FROM AccountsTrips act
JOIN Trips t ON act.TripId = t.Id
JOIN Accounts a ON act.AccountId = a.Id
WHERE MiddleName IS NULL AND CancelDate IS NULL
GROUP BY AccountId, FirstName, LastName --За да разполагаме с тези две колони ги слагаме в Group by! Те не носят уникалност
ORDER BY 
	LongestTrip DESC,
	ShortestTrip


--8. Metropolis

SELECT TOP(10)
	c.Id,
	c.Name AS City,
	c.CountryCode AS Country,
	COUNT(*) AS Accounts
FROM Accounts a
JOIN Cities c ON a.CityId = c.Id 
GROUP BY c.Name, c.CountryCode, c.Id
ORDER BY Accounts Desc



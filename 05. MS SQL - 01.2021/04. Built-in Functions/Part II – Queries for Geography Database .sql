USE Geography

--Problem 12.	Countries Holding ‘A’ 3 or More Times

SELECT CountryName AS [Country Name], IsoCode AS [ISO Code] FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode

--Problem 13.	 Mix of Peak and River Names

SELECT 
	p.PeakName,
	r.RiverName,
	LOWER(SUBSTRING(p.PeakName, 1, Len(p.PeakName) - 1) + r.RiverName) AS Mix
FROM Peaks AS p, Rivers AS r
WHERE RIGHT(p.PeakName, 1) = LEFT(r.RiverName, 1)
ORDER BY Mix

--Second way

SELECT
	p.PeakName,
	r.RiverName,
	LOWER(SUBSTRING(p.PeakName, 1, Len(p.PeakName) - 1) + r.RiverName) AS Mix
FROM Peaks p
JOIN Rivers r ON RIGHT(p.PeakName, 1) = LEFT(r.RiverName,1)
ORDER BY Mix
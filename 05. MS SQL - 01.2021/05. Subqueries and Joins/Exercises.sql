USE SoftUni

--10. Employee Summary

SELECT TOP(50) 
	e.EmployeeID,
	(e.FirstName + ' ' + e.LastName) AS EmployeeName,
	(em.FirstName + ' ' + em.LastName) AS ManagerName,
	d.Name AS DepartmentName
FROM Employees e
JOIN Employees em
ON em.EmployeeID = e.ManagerID
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID

--11. Min Average Salary

SELECT TOP(1) AVG(Salary) AS MinAverageSalary FROM Employees
GROUP BY DepartmentID
ORDER BY MinAverageSalary

USE Geography

--12. Highest Peaks in Bulgaria

SELECT 
	mc.CountryCode,
	m.MountainRange,
	p.PeakName,
	p.Elevation
FROM Peaks p
JOIN Mountains m
ON p.MountainId = m.Id
JOIN MountainsCountries mc
ON m.Id = mc.MountainId
WHERE p.Elevation >= 2835 AND mc.CountryCode = 'BG'
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges

SELECT CountryCode, COUNT(*) from Mountains m
JOIN MountainsCountries mc
ON m.Id = mc.MountainId
WHERE mc.CountryCode IN ('BG', 'US', 'RU')
GROUP BY CountryCode

--14. Countries with Rivers

SELECT TOP(5) c.CountryName, r.RiverName FROM Rivers r 
RIGHT JOIN CountriesRivers cr
ON r.Id = cr.RiverId
RIGHT JOIN Countries c
ON c.CountryCode = cr.CountryCode
RIGHT JOIN Continents cn
ON c.ContinentCode = cn.ContinentCode
WHERE cn.ContinentName = 'Africa'
ORDER BY c.CountryName

--15. *Continents and Currencies

USE Geography

SELECT * FROM
(SELECT 
	ContinentCode,
	CurrencyCode,
	COUNT(*) AS CurrencyUsage,
	DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY COUNT(*) DESC) AS Ranking
FROM Countries
GROUP BY ContinentCode, CurrencyCode) AS T
WHERE Ranking = 1
ORDER BY ContinentCode

--16. Countries Without Any Mountains

SELECT COUNT(*) AS COUNT
FROM Countries c
LEFT JOIN MountainsCountries mc
ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains m
ON m.Id = mc.MountainId
WHERE m.MountainRange IS NULL

--17. Highest Peak and Longest River by Country

SELECT TOP(5) CountryName, HighestPeakElevation, LongestRiverLength FROM
(SELECT 
	c.CountryName,
	c.Capital,
	p.Elevation AS HighestPeakElevation,
	p.PeakName,
	m.MountainRange,
	r.Length AS LongestRiverLength,
	r.RiverName,
	ROW_NUMBER () OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS PeakRank,
	ROW_NUMBER () OVER (PARTITION BY c.CountryName ORDER BY r.Length DESC) AS RiverRank
FROM Countries c
JOIN CountriesRivers cr
ON cr.CountryCode = c.CountryCode 
JOIN Rivers r
ON r.Id = cr.RiverId
JOIN MountainsCountries mc
ON mc.CountryCode = c.CountryCode
JOIN Mountains m
ON m.Id = mc.MountainId
JOIN Peaks p
ON p.MountainId = m.Id) AS T
WHERE PeakRank = 1 AND RiverRank = 1
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, CountryName ASC


--18. Highest Peak Name and Elevation by Country

SELECT 
	Country,
	ISNULL([Highest Peak Name], '(no highest peak)'),
	ISNULL([Highest Peak Elevation], '0'),
	ISNULL(Mountain, '(no mountain)')
FROM
(SELECT 
	c.CountryName AS Country,
	c.Capital,
	p.Elevation AS [Highest Peak Elevation],
	p.PeakName AS [Highest Peak Name],
	m.MountainRange AS Mountain,
	ROW_NUMBER () OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS PeakRank
FROM Countries c
LEFT JOIN MountainsCountries mc
ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains m
ON m.Id = mc.MountainId
LEFT JOIN Peaks p
ON p.MountainId = m.Id) AS T
WHERE PeakRank = 1
ORDER BY Country ASC, [Highest Peak Name] ASC
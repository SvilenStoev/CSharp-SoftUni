--2.	Villain Names

SELECT v.Name, COUNT(mv.VillainId) FROM Villains v
JOIN MinionsVillains mv ON v.Id = mv.VillainId
GROUP BY v.Name
HAVING COUNT(mv.VillainId) > 3
ORDER BY COUNT(mv.VillainId) DESC

--3.	Minion Names

SELECT Name FROM Villains
WHERE id = 1

SELECT v.Name, m.Name AS Name2, m.Age FROM Villains v
JOIN MinionsVillains mv ON mv.VillainId = v.Id
JOIN Minions m ON m.Id = mv.MinionId
Where v.Id = '1'

INSERT INTO Villains(Name, EvilnessFactorId) VALUES
('Pesho', 1)

SELECT * FROM Villains
CREATE DATABASE BB206
USE BB206

CREATE TABLE Countries(
	Id INT PRIMARY KEY IDENTITY,
	[Name] nvarchar(20) NOT NULL,
	[Population] INT,
)

CREATE TABLE Cities(
	Id INT PRIMARY KEY IDENTITY,
	[Name] nvarchar(20) NOT NULL,
	[Population] INT,
	CountryId INT REFERENCES Countries(Id)
)

CREATE TABLE Villages(
	Id INT PRIMARY KEY IDENTITY,
	[Name] nvarchar(20) NOT NULL,
	[Population] INT,
	CityId INT REFERENCES Cities(Id)
)

-- Inner Join
SELECT * FROM Countries
JOIN Cities
ON 
Countries.Id = Cities.CountryId
JOIN Villages
ON 
Villages.CityId = Cities.Id

-- Right Join

SELECT * FROM Countries
RIGHT JOIN Cities
ON
Countries.Id = Cities.CountryId

SELECT * FROM Cities
RIGHT JOIN Countries
ON
Countries.Id = Cities.CountryId

-- Left Join
SELECT * FROM Cities
LEFT JOIN Countries
ON
Countries.Id = Cities.CountryId

-- FULL OUTOR JOIN
SELECT * FROM Cities
FULL JOIN Countries
ON
Countries.Id = Cities.CountryId

-- Self Join

CREATE TABLE Positions(
	Id INT PRIMARY KEY IDENTITY,
	[Name] nvarchar(20),
	DependonId INT REFERENCES Positions(Id)
)

SELECT * FROM Positions as p
JOIN Positions as o
ON
p.DependonId = o.Id

-- Cross Join

CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY,
	[Name] nvarchar(20),
	Price decimal,
)

CREATE TABLE Sizes(
	Id INT PRIMARY KEY IDENTITY,
	[Name] nvarchar(20)
)

SELECT * FROM Products
CROSS JOIN Sizes


-- Non equi Join

CREATE TABLE Students(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(20),
	Grade int NOT NULL
)

CREATE TABLE Points(
	Id INT PRIMARY KEY IDENTITY,
	LetterPoint nvarchar NOT NULL,
	MaxGrade int,
	MinGrade int
)

SELECT * FROM Students
JOIN Points
ON 
Students.Grade >= Points.MinGrade AND Students.Grade <= Points.MaxGrade
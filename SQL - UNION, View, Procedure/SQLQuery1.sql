CREATE DATABASE BB206SHOP

USE BB206SHOP

CREATE TABLE Brands
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(25) UNIQUE
)

CREATE TABLE Notebooks
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(25),
	Price DECIMAL (18,2),
	BrandId INT FOREIGN KEY REFERENCES Brands(Id)
)

CREATE TABLE Phones
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(25),
	Price DECIMAL (18,2),
	BrandId INT FOREIGN KEY REFERENCES Brands(Id)
)

ALTER TABLE Phones
ADD Memory INT

INSERT INTO Brands
VALUES
('Apple'),
('Samsung'),
('Xiaomi'),
('Honor')


SELECT * FROM Brands

INSERT INTO Notebooks
VALUES
('Macbook Air', 1700, 1),
('Macbook Pro', 2700, 1),
('Galaxy Books', 1500, 2),
('Galaxy Books Pro', 2400, 2),
('Xiaomi Notebook', 900, 3),
('Xiaomi Notebook Pro', 1200, 3),
('Magicbook', 800, 4),
('Magicbook PRO', 1700, 4)

INSERT INTO Phones
VALUES
('Iphone 13', 1700, 1),
('Iphone 14 Pro', 2700, 1),
('Galaxy S5', 1500, 2),
('Galaxy S23 ULTRA', 2400, 2),
('Xiaomi Redmi Note 8 PRO', 900, 3),
('Xiaomi Redmi Note 10', 1200, 3),
('Magicbook', 800, 4),
('Honor X', 1700, 4)

SELECT * FROM Notebooks
SELECT * FROM Brands
SELECT * FROM Phones

SELECT N.Id, N.Name AS 'Product Name', N.Price AS 'Product Price', B.Name AS 'Brand Name'  
FROM Notebooks AS N
JOIN Brands AS B
ON N.BrandId = B.Id
UNION ALL
SELECT P.Id, P.Name AS 'Product Name', p.Price AS 'Product Price', B.Name AS 'Brand Name'
FROM Phones AS P
JOIN Brands AS B
ON B.Id = P.BrandId


Select TotalProducts.[Brand Name], SUM(TotalProducts.[Product Count]) AS TOTAL FROM 
(SELECT B.Name AS 'Brand Name', COUNT(N.Name) AS 'Product Count', SUM(N.Price) 
AS 'Total Price'
FROM Notebooks AS N
JOIN Brands AS B
ON N.BrandId = B.Id
GROUP BY B.Name
UNION ALL
SELECT B.Name AS 'Brand Name', COUNT(P.Name) AS 'Product Count', SUM(P.Price) AS 'Total Price'
FROM Phones AS P
JOIN Brands AS B
ON P.BrandId = B.Id
GROUP BY B.Name) AS TotalProducts
GROUP BY TotalProducts.[Brand Name]


SELECT * FROM Notebooks
WHERE Notebooks.BrandId = 1

SELECT * FROM Notebooks
Where Notebooks.Price > 1500

SELECT * FROM Notebooks
WHERE Notebooks.Name LIKE '%o%'


SELECT N.Id, N.Name AS 'Product Name', N.Price AS 'Product Price', B.Name AS 'Brand Name'  
FROM Notebooks AS N
JOIN Brands AS B
ON N.BrandId = B.Id
WHERE B.Name LIKE '%a%'

SELECT N.Id, N.Name AS 'Product Name', N.Price AS 'Product Price', B.Name AS 'Brand Name'  
FROM Notebooks AS N
JOIN Brands AS B
ON N.BrandId = B.Id
WHERE B.Name LIKE 'a%'


CREATE VIEW VW_NOTEBOOKSTHATCONTAINS_A
AS
SELECT N.Id, N.Name AS 'Product Name', N.Price AS 'Product Price', B.Name AS 'Brand Name'  
FROM Notebooks AS N
JOIN Brands AS B
ON N.BrandId = B.Id
WHERE B.Name LIKE '%a%'

CREATE VIEW VW_PRODUCT_PRICE_GREATER_THAN_1700
AS
SELECT * FROM VW_NOTEBOOKSTHATCONTAINS_A
WHERE VW_NOTEBOOKSTHATCONTAINS_A.[Product Price] > 1700


SELECT * FROM VW_PRODUCT_PRICE_GREATER_THAN_1700



CREATE PROCEDURE USP_FILTER_NOTEBOOKS_BY_PRICE2 @price DECIMAL(18,2), @id INT
AS
SELECT * FROM Notebooks AS N
JOIN Brands AS B
ON B.Id = N.BrandId
WHERE N.Price >= @price



EXEC USP_FILTER_NOTEBOOKS_BY_PRICE 1700

ALTER PROCEDURE USP_FILTER_NOTEBOOKS_BY_PRICE @name NVARCHAR(25)
AS
SELECT * FROM Notebooks AS N
JOIN Brands AS B
ON B.Id = N.BrandId
WHERE B.Name LIKE @name

EXEC USP_FILTER_NOTEBOOKS_BY_PRICE '%i%'
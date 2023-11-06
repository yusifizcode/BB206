CREATE DATABASE BB206BookShop
USE BB206BookShop


CREATE TABLE Libraries(
	Id INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Genres(
	Id INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Authors(
	Id INT IDENTITY PRIMARY KEY,
	FullName NVARCHAR(50) NOT NULL,
	Age INT CHECK(Age>0),
	Experience INT CHECK(Experience>0)
)

CREATE TABLE Books(
	Id INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[PageCount] INT CHECK([PageCount]>0),
	Price DECIMAL(18,2) CHECK(Price>0) NOT NULL,
	AuthorId INT FOREIGN KEY REFERENCES Authors(Id),
	LibraryId INT FOREIGN KEY REFERENCES Libraries(Id)
)

CREATE TABLE BookGenres(
	Id INT IDENTITY PRIMARY KEY,
	BookId INT FOREIGN KEY REFERENCES Books(Id),
	GenreId INT FOREIGN KEY REFERENCES Genres(Id)
)

SELECT a.FullName, SUM(b.Price) as 'Total price' FROM Books as b
JOIN Authors as a
ON
b.AuthorId = a.Id
GROUP BY a.FullName

-- Yazdiginiz queryni view shekline salin, Daha sonra Price'a gore filter eden Procedure yazin.

CREATE VIEW vw_BookCount
AS
SELECT a.FullName, COUNT(b.Id) as 'BookCount' FROM Books b
JOIN Authors a
ON
b.AuthorId = a.Id
GROUP BY a.FullName


SELECT * FROM vw_BookCount



CREATE PROCEDURE usp_FilterBooksByPrice @price INT
AS
SELECT * FROM Books
WHERE Books.Price > @price

DROP PROCEDURE usp_FilterBooksByPrice

EXEC usp_FilterBooksByPrice 1000
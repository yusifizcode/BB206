CREATE DATABASE CompanyDB
USE CompanyDB

CREATE TABLE Departments(
	Name nvarchar(15) NOT NULL UNIQUE
)

CREATE TABLE Employees(
	[Name] nvarchar(15) NOT NULL,
	Surname nvarchar(20) NOT NULL,
	Salary decimal NOT NULL,
	Email nvarchar(30) NOT NULL UNIQUE,
	DepartmentName nvarchar(30) NOT NULL
)

DROP TABLE Employees
ALTER TABLE Employees ADD Age int

ALTER TABLE Employees ALTER COLUMN Age bit
ALTER TABLE Employees DROP COLUMN Age


INSERT INTO Departments 
VALUES
('IT'),
('Marketing'),
('Sales')

SELECT * FROM Departments

INSERT INTO Employees
VALUES
('Shahin','Ismayilov',600,'sh_mekansiz@gmail.com','Marketing'),
('Ulker','Veliyeva',600,'ulkervly@gmail.com','Marketing'),
('Remzi','Hesenov',6000,'remzi@gmail.com','Sales'),
('Elmar','BYK',300,'byk_elmar@gmail.com','IT'),
('Elvin','Sarkarov',3000,'elvin@gmail.com','IT')


UPDATE Employees SET Salary = 6000
WHERE Surname = 'Ismayilov'

SELECT * FROM Employees

DELETE FROM Employees WHERE Salary = 6000

SELECT * FROM Employees WHERE Salary > 1000
SELECT * FROM Employees WHERE Salary > 1000 AND Salary < 3500
SELECT * FROM Employees WHERE Salary BETWEEN 1000 AND 3500

SELECT Name + ' ' + Surname as 'FullName' FROM Employees

SELECT * FROM Employees WHERE Name LIKE '%a%'
/* В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий,
в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
Если у продукта нет категорий, то его имя все равно должно выводиться.*/
CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name NVARCHAR(50) NOT NULL,
	)
	
CREATE TABLE Categorys(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name NVARCHAR(50) NOT NULL,
	)
	
CREATE TABLE ProductsCategorys(
	ProductId INT,
	CategoryId INT
	PRIMARY KEY(ProductId, CategoryId),
	FOREIGN KEY(ProductId) REFERENCES Products(Id),
	FOREIGN KEY(CategoryId) REFERENCES Categorys(Id)
	)
	
INSERT INTO Products(Name) VALUES
	('Product 1')
INSERT INTO Products(Name) VALUES
	('Product 2')
INSERT INTO Products(Name) VALUES
	('Product 3')
INSERT INTO Products(Name) VALUES
	('Product 4')
	
INSERT INTO Categorys(Name) VALUES
	('Category 1')
INSERT INTO Categorys(Name) VALUES
	('Category 2')
INSERT INTO Categorys(Name) VALUES
	('Category 3')
	
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (1, 1)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (1, 2)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (2, 1)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (2, 2)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (2, 3)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (3, 1)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (3, 2)
INSERT INTO ProductsCategorys(ProductId, CategoryId) VALUES (3, 3)

SELECT * 
FROM Products P 
LEFT JOIN ProductsCategorys PC
ON P.Id = PC.ProductId
WHERE P.Name = 'Product 2'

SELECT * 
FROM Products P 
LEFT JOIN ProductsCategorys PC
ON P.Id = PC.ProductId
WHERE P.Name = 'Product 4'

/* Ответ*/
SELECT P.Name AS Product_Name, C.Name AS Category_Name  
FROM Products P 
LEFT JOIN ProductsCategorys PC
ON P.Id = PC.ProductId
LEFT JOIN Categorys C
ON PC.CategoryId = C.Id
WHERE P.Name = 'Product 2'

SELECT P.Name AS Product_Name, C.Name AS Category_Name 
FROM Products P 
LEFT JOIN ProductsCategorys PC
ON P.Id = PC.ProductId
LEFT JOIN Categorys C
ON PC.CategoryId = C.Id
WHERE P.Name = 'Product 4'

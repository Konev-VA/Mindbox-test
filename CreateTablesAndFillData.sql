CREATE TABLE Products
(
	ProductId INT IDENTITY(1,1) NOT NULL,
	[ProductName] VARCHAR(100),
	PRIMARY	 KEY(ProductId)
)

GO

CREATE TABLE Categories
(
	CategoryId  INT IDENTITY(1,1),
	[CategoryName] VARCHAR(100),
	PRIMARY KEY(CategoryId)
)

GO

CREATE TABLE ProductsCategoriesLinks
(
	ProductId INT FOREIGN KEY REFERENCES Products(ProductId),
	CategoryId INT FOREIGN KEY REFERENCES Categories(CategoryId)
)

GO

INSERT INTO Products(ProductName) VALUES('Banana')
INSERT INTO Products(ProductName) VALUES('Chocolate')
INSERT INTO Products(ProductName) VALUES('Cigarettes')
INSERT INTO Products(ProductName) VALUES('Candies')
INSERT INTO Products(ProductName) VALUES('Apples')
INSERT INTO Products(ProductName) VALUES('Alcohol')
INSERT INTO Products(ProductName) VALUES('Bread')
INSERT INTO Products(ProductName) VALUES('Milk')
INSERT INTO Products(ProductName) VALUES('Kefir')
INSERT INTO Products(ProductName) VALUES('Sour Cream')
INSERT INTO Products(ProductName) VALUES('Potato')
INSERT INTO Products(ProductName) VALUES('Cucumbers')

GO

INSERT INTO Categories(CategoryName) VALUES('18+')
INSERT INTO Categories(CategoryName) VALUES('Main Products')
INSERT INTO Categories(CategoryName) VALUES('Dairy products')
INSERT INTO Categories(CategoryName) VALUES('Fruits')

GO

INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (1, 4)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (3, 1)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (5, 4)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (5, 2)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (6, 1)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (7, 2)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (8, 2)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (8, 3)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (9, 3)
INSERT INTO ProductsCategoriesLinks(ProductId, CategoryId) VALUES (10, 3)

GO
CREATE DATABASE ShoppingCartDb

USE ShoppingCartDb

CREATE TABLE Users (
    UserId INT PRIMARY KEY,
    UserName VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20),
    City VARCHAR(100)
);

INSERT INTO Users VALUES (1, 'JohnDoe', 'password123', '555-1234', 'New York');
INSERT INTO Users VALUES (2, 'JaneSmith', 'securepass', '555-5678', 'Los Angeles');
INSERT INTO Users VALUES (3, 'MikeBrown', 'mypassword', '555-8765', 'Chicago');
INSERT INTO Users VALUES (4, 'EmilyDavis', 'passw0rd', '555-4321', 'Houston');
INSERT INTO Users VALUES (5, 'DavidWilson', '1234password', '555-6789', 'Phoenix');

SELECT * FROM Users

CREATE TABLE Products(
	ProductId INT PRIMARY KEY,
	Name varchar(50) NOT NULL,
	QuantityInStock INT NOT NULL,
	UnitPrice INT NOT NULL,
	Category varchar(50) NOT NULL,
	CONSTRAINT CHK_Products_QuantityInStock CHECK(QuantityInStock>0),
	CONSTRAINT CHK_Products_UnitPrice CHECK(UnitPrice>0)
)

INSERT INTO Products VALUES (1, 'Laptop', 50, 1000, 'Electronics');
INSERT INTO Products VALUES (2, 'Smartphone', 200, 800, 'Electronics');
INSERT INTO Products VALUES (3, 'Desk Chair', 150, 120, 'Furniture');
INSERT INTO Products VALUES (4, 'Notebook', 500, 5, 'Stationery');
INSERT INTO Products VALUES (5, 'Water Bottle', 300, 15, 'Accessories');

SELECT * FROM Products


INSERT INTO Products  (ProductId, Name, QuantityInStock, UnitPrice, Category) VALUES (6, 'Hp', 0, 1000, 'Laptap');

INSERT INTO Products  (ProductId, Name, Category) VALUES (7, 'Hp', 'Laptap');

INSERT INTO Products  (ProductId, Name, QuantityInStock, UnitPrice, Category) VALUES (8, 'Hp', 90, 0, 'Laptap');

CREATE TABLE Cart(
	Id INT,
	CartId INT NOT NULL,
	ProductId INT,
	Quantity INT NOT NULL ,
	CONSTRAINT  PK_CART_ID  PRIMARY KEY (Id),
	CONSTRAINT CHK_Cart_Quantity CHECK(Quantity>0),
	CONSTRAINT FK_Cart_ProductId FOREIGN KEY(ProductId) REFERENCES Products(ProductId)
	ON DELETE CASCADE
	ON UPDATE CASCADE
)

INSERT INTO Cart VALUES (1, 101, 1, 2);
INSERT INTO Cart VALUES (2, 101, 2, 1);
INSERT INTO Cart VALUES (3, 102, 3, 4);
INSERT INTO Cart VALUES (4, 103, 4, 10);
INSERT INTO Cart VALUES (5, 104, 5, 3);
INSERT INTO Cart VALUES (6, 105, 1, 1);


SELECT * FROM Products
SELECT * FROM Products WHERE Category = 'Electronics';
SELECT * FROM Products WHERE QuantityInStock = 0;
SELECT * FROM Products WHERE UnitPrice BETWEEN 1000 AND 10000;
SELECT * FROM Products WHERE ProductId = 1;


SELECT * FROM Cart WHERE CartId = 101;
SELECT * FROM Cart WHERE ProductId = 1;

SELECT * FROM Users;
SELECT * FROM Users WHERE ContactNumber = '555-1234';
SELECT * FROM Users WHERE UserId = 4;



--2.1.b
SELECT Cart.CartId, Products.Name AS ProductName, Cart.Quantity, Products.UnitPrice
FROM Cart
JOIN Products ON Cart.ProductId = Products.ProductId;

--2.1.c

SELECT Cart.CartId, Products.Name AS ProductName, Cart.Quantity, Products.UnitPrice
FROM Cart
INNER JOIN Products ON Cart.ProductId = Products.ProductId;

SELECT Cart.CartId, Products.Name AS ProductName, Cart.Quantity, Products.UnitPrice
FROM Cart
LEFT OUTER JOIN Products ON Cart.ProductId = Products.ProductId;

SELECT Cart.CartId, Products.Name AS ProductName, Cart.Quantity, Products.UnitPrice
FROM Cart
RIGHT OUTER JOIN Products ON Cart.ProductId = Products.ProductId;

SELECT Cart.CartId, Products.Name AS ProductName, Cart.Quantity, Products.UnitPrice
FROM Cart
FULL OUTER JOIN Products ON Cart.ProductId = Products.ProductId;


--2.2
CREATE TABLE Student (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(100),
    CourseName VARCHAR(100),
    CityName VARCHAR(100),
    ContactNumber VARCHAR(15)
);

INSERT INTO Student VALUES (1, 'John Doe', 'Angular', 'Hyderabad', '1234567890');
INSERT INTO Student VALUES (2, 'Jane Smith', 'React', 'Mumbai', '2345678901');
INSERT INTO Student VALUES (3, 'Alice Johnson', 'Angular', 'Hyderabad', '3456789012');
INSERT INTO Student VALUES (4, 'Bob Brown', 'Vue', 'Bangalore', '4567890123');
INSERT INTO Student VALUES (5, 'Charlie Davis', 'Angular', 'Chennai', '5678901234');
INSERT INTO Student VALUES (6, 'Diana Evans', 'React', 'Hyderabad', '6789012345');
INSERT INTO Student VALUES (7, 'Ethan Harris', 'Vue', 'Mumbai', '7890123456');
INSERT INTO Student VALUES (8, 'Fiona Clark', 'Angular', 'Hyderabad', '8901234567');
INSERT INTO Student VALUES (9, 'George Lewis', 'React', 'Chennai', '9012345678');
INSERT INTO Student VALUES (10, 'Hannah Walker', 'Vue', 'Bangalore', '0123456789');

--2.2.a
SELECT COUNT(*) AS AngularStudentsCount FROM Student WHERE CourseName = 'Angular';

--2.2.b
SELECT COUNT(*) AS HyderabadStudentsCount FROM Student WHERE CityName = 'Hyderabad';

--2.2.c
SELECT CityName, COUNT(*) AS StudentsCount FROM Student GROUP BY CityName;

--2.2.d
SELECT CourseName, COUNT(*) AS StudentsCount FROM Student GROUP BY CityName;

--2.2.e
SELECT  COUNT(*) AS StudentsCount FROM Student GROUP BY CourseName, CityName;


--2.3.a
SELECT * FROM Products WHERE ProductId IN (SELECT ProductId FROM Cart);

--2.3.b
SELECT * FROM Cart WHERE ProductId IN (SELECT ProductId FROM Products WHERE UnitPrice > 5000);


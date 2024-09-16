SELECT *   FROM Products

CREATE VIEW "Products Less Than Average Price"  AS SELECT * FROM Products where UnitPrice<(Select AVG(UnitPrice) FROM Products);

SELECT * FROM  "Products Less Than Average Price"

EXEC sp_rename 'Products Less Than Average Price', 'Low Cost Products';

DROP VIEW "Low Cost Products";
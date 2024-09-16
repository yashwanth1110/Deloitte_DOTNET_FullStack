
 use northwind;

ALTER PROCEDURE  usdProducts
AS
BEGIN
	 SELECT * FROM Products  ;

END;
EXEC usdProducts;


ALTER  PROCEDURE  KProducts
AS
BEGIN
	 SELECT sum(UnitPrice) AS TotalAmount ,ProductName from Products GROUP BY ProductName ;

END;
EXEC KProducts;



DECLARE cursor_pro CURSOR
FOR SELECT ProductName, UnitPrice*UnitsOnOrder as TotalAmount FROM  Products;
DECLARE @ProductName VARCHAR(MAX),  @TotalAmount   DECIMAL(10,2),  @GrandTotal   DECIMAl(10,2) ;
set @GrandTotal=0.00;
OPEN cursor_pro;
FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @ProductName + ' - ' +  CAST(@TotalAmount AS varchar);
        FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;
		set @GrandTotal=@GrandTotal+@TotalAmount;
    END;
 PRINT 'GrandTotal' + ' - ' +  CAST(@GrandTotal AS varchar);
	CLOSE cursor_pro;

deallocate cursor_pro;




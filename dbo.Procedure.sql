CREATE PROCEDURE sproc_tblProduct_filterByProductID
--parameter to store the product ID we are looking for
@Product_ID int
AS
--select all fields from the table where the product_id matches the parameter data
	SELECT * from Product where Product_ID = @Product_ID

RETURN 0

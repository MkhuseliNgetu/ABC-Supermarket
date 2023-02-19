CREATE PROCEDURE SP_RemoveAProduct(
@ItemName VARCHAR(100) = ''

)
AS
BEGIN
DELETE FROM Products
WHERE @ItemName=ItemName;



END


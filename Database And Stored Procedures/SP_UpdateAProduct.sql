CREATE PROCEDURE SP_UpdateAProduct(
@Picture IMAGE = '',
@ItemName VARCHAR(100) = '',
@ItemDescription VARCHAR(200) = '',
@ItemPrice INT = 0
)
AS
BEGIN

UPDATE Products
SET Picture=@Picture,ItemDescription=@ItemDescription,ItemPrice=@ItemPrice
WHERE @ItemName=ItemName;



END
CREATE PROCEDURE SP_CreateAProduct(
@Picture IMAGE = '',
@ItemName VARCHAR(100) = '',
@ItemDescription VARCHAR(200) = '',
@ItemPrice INT = 0
)
AS
BEGIN

INSERT INTO Products
VALUES(@Picture,@ItemName,@ItemDescription,@ItemPrice);


END
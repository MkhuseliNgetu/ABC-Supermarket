USE Master;
CREATE DATABASE ProductStorage;

USE ProductStorage;

CREATE TABLE Products(
Picture IMAGE NOT NULL,
ItemName VARCHAR(100) NOT NULL PRIMARY KEY,
ItemDescription VARCHAR(200) NOT NULL,
ItemPrice INT NOT NULL,
);



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

CREATE PROCEDURE SP_RemoveAProduct(
@ItemName VARCHAR(100) = ''

)
AS
BEGIN
DELETE FROM Products
WHERE @ItemName=ItemName;



END




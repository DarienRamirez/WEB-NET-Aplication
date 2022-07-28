CREATE DATABASE NETFramework

USE NETFramework

CREATE TABLE Products 
(productID INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
productName varchar(MAX),
productPrice integer,
typeID integer,
colorID integer,
rating integer,
productDescription varchar(max),
productImage image,
productTimestamp date)

CREATE TABLE Types 
(typeID INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
typeName varchar(MAX),
typeTimestamp date)

CREATE TABLE Colors 
(colorID INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
colorName varchar(MAX),
colorTimestamp date)

--Creacion procedure para obtener todos los productos
CREATE PROCEDURE sp_SaveProducts 
@p_productName varchar(max),
@p_productPrice integer,
@p_typeID integer,
@p_colorID integer,
@p_rating integer,
@p_productDescription nvarchar(max),
@p_productImage image
AS
BEGIN
	INSERT INTO Products (productName,productPrice,typeID,colorID,rating,productDescription,productImage,productTimestamp)
	VALUES(@p_productName,@p_productPrice,@p_typeID,@p_colorID,@p_rating,@p_productDescription,@p_productImage,(SELECT GETDATE()))
END
GO

CREATE PROCEDURE sp_SaveProducts 
@p_productName varchar(max),
@p_productPrice integer,
@p_typeID integer,
@p_colorID integer,
@p_rating integer,
@p_productDescription nvarchar(max),
@p_productImage image
AS
BEGIN
	INSERT INTO Products (productName,productPrice,typeID,colorID,rating,productDescription,productImage,productTimestamp)
	VALUES(@p_productName,@p_productPrice,@p_typeID,@p_colorID,@p_rating,@p_productDescription,@p_productImage,(SELECT GETDATE()))
END
GO

CREATE PROCEDURE sp_DeleteProduct
@p_productID INT
AS
BEGIN	
	DELETE FROM Products WHERE productID = @p_productID
END
GO
CREATE PROCEDURE sp_GetAllProducts
AS
BEGIN	
	SELECT productImage,productID,productName,productDescription,rating,productPrice FROM Products

END
GO
CREATE PROCEDURE sp_GetTopProducts
@p_productID int
AS
BEGIN	
	SELECT TOP 1 * FROM Products WHERE productID = @p_productID
END
GO


CREATE PROCEDURE sp_GetColors
AS
BEGIN	
	SELECT colorID as ID,colorName as COLOR, colorTimestamp registro FROM Colors
END
GO
CREATE PROCEDURE sp_SaveColor
@p_colorName varchar(max)
AS
BEGIN
	INSERT INTO Colors(colorName,colorTimestamp)
	VALUES(@p_colorName,(SELECT GETDATE()))
END
GO
CREATE PROCEDURE sp_ModifyColors
@p_colorId int,
@p_colorName varchar(MAX)
AS
BEGIN	
	UPDATE Colors SET colorName = @p_colorName WHERE colorID = @p_colorId
END
GO

CREATE PROCEDURE sp_DeleteColors
@p_colorId INT
AS
BEGIN	
	DELETE FROM Colors WHERE colorID = @p_colorId
END
GO
CREATE PROCEDURE sp_GetTopColors
@p_colorId int
AS
BEGIN	
	SELECT TOP 1 colorName FROM Colors WHERE Colors.colorID = @p_colorId
END
GO


CREATE PROCEDURE sp_SaveType
@p_typeName varchar(max)
AS
BEGIN
	INSERT INTO Types(typeName,typeTimestamp)
	VALUES(@p_typeName,(SELECT GETDATE()))
END
GO


CREATE PROCEDURE sp_ModifyTypes
@p_typeId int,
@p_typeName varchar(MAX)
AS
BEGIN	
	UPDATE Types SET typeName = @p_typeName WHERE typeID = @p_typeId
END
GO


CREATE PROCEDURE sp_GetTopTypes
@p_typeID int
AS
BEGIN	
	SELECT TOP 1 typeName FROM Types WHERE Types.typeID = @p_typeID
END
GO


CREATE PROCEDURE sp_GetTypes
AS
BEGIN	
	SELECT typeID as ID,typeName as Tipo ,typeTimestamp as 'Registro' FROM Types
END
GO

CREATE PROCEDURE sp_DeleteTypes
@p_typeID INT
AS
BEGIN	
	DELETE FROM Types WHERE typeID = @p_typeID
END
GO

use NETFramework
select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN' 
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
    end
    as ConnectionString
from sys.server_principals
where name = suser_name()

SELECT GETDATE()
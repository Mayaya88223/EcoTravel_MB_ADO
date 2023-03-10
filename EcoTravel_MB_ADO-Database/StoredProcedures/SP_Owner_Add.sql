CREATE PROCEDURE [dbo].[SP_Owner_Add]
	@Nom NVARCHAR(50),
	@Prénom NVARCHAR(50),
	@Telephone NVARCHAR(50),
	@Email NVARCHAR(50),
	@Password VARBINARY(64),
	@Pays NVARCHAR(50)
AS
	INSERT INTO [Owner] 
	OUTPUT [inserted].[IdClient]
	VALUES (@Email, HASHBYTES('SHA2_512',@Password), @Nom, @Prénom, @Pays, @Telephone)
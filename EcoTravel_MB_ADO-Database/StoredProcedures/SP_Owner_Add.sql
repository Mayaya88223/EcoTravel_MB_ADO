CREATE PROCEDURE [dbo].[SP_Owner_Add]
	@IdClient INT
AS
	INSERT INTO [Owner] 
	OUTPUT [inserted].[IdClient]
	VALUES (@IdClient)
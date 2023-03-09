CREATE PROCEDURE [dbo].[SP_ClientCheck]
	@Email NVARCHAR(50),
	@Password VARBINARY(64)
AS
	SELECT [idClient]
	FROM [Client] 
	WHERE	[Email] = @email 
		AND [Password] = HASHBYTES('SHA2_512',@Password)


CREATE PROCEDURE [dbo].[SP_ClientCheck]
	@Email NVARCHAR(50),
	@Password NVARCHAR(50)
AS
	SELECT [IdClient]
	FROM [Client] 
	WHERE	[Email] = @email 
		AND [Password] = HASHBYTES('SHA2_512',@Password)


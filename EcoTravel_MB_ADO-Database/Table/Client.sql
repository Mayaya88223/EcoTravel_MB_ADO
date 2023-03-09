CREATE TABLE [dbo].[Client]
(
	[IdClient] INT NOT NULL IDENTITY (1,1), 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prénom] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Pays] NVARCHAR(50) NOT NULL, 
    [Telephone] NVARCHAR(50) NOT NULL, 
    [Password] VARBINARY(64) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([IdClient]),
    CONSTRAINT [UK_Client_email] UNIQUE ([email]),
    CONSTRAINT [CK_Client_email] CHECK ([email] LIKE ('%__@__%.__%')),
    CONSTRAINT [CK_Client_telephone] CHECK (ISNUMERIC(REPLACE(REPLACE(REPLACE([telephone], '+', '00'), '/', ''), '.', '')) = 1),
    CONSTRAINT [CK_Client_Nom] CHECK (LEN([Nom]) >= 1), 
    CONSTRAINT [CK_Client_Prénom] CHECK (LEN([Prénom]) >= 1),

)
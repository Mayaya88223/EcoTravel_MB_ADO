CREATE TABLE [dbo].[Client]
(
	[IdClient] INT NOT NULL , 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prénom] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Pays] NVARCHAR(50) NOT NULL, 
    [Telephone] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY ([IdClient])
)

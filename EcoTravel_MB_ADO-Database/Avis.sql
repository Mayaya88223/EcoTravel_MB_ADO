CREATE TABLE [dbo].[Avis]
(
	[IdAvis] INT NOT NULL, 
    [Notes] TINYINT NOT NULL, 
    [Commentaire] NVARCHAR(50) NULL, 
    [Categorie_User] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Avis] PRIMARY KEY ([IdAvis])  
)

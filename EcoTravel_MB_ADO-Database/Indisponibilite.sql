CREATE TABLE [dbo].[Indisponibilite]
(
	[IdIndisponible] INT NOT NULL IDENTITY (1,1), 
    [Date_debut] DATETIME NULL DEFAULT GETDATE(), 
    [Date_fin] DATETIME NULL DEFAULT GETDATE(), 
    [IdLogement] INT NULL, 
    CONSTRAINT [PK_Indisponibilite] PRIMARY KEY ([IdIndisponible]), 
    CONSTRAINT [FK_Indisponibilite_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]) 
)

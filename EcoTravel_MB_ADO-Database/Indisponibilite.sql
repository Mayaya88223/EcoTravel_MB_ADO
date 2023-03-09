CREATE TABLE [dbo].[Indisponibilite]
(
	[IdIndisponible] INT NOT NULL, 
    [Date_debut] DATETIME NULL, 
    [Date_fin] DATETIME NULL, 
    [IdLogement] INT NULL, 
    CONSTRAINT [PK_Indisponibilite] PRIMARY KEY ([IdIndisponible]), 
    CONSTRAINT [FK_Indisponibilite_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]) 
)

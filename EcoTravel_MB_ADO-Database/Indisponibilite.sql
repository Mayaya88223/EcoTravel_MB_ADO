CREATE TABLE [dbo].[Indisponibilite]
(
	[IdIndisponible] INT NOT NULL, 
    [Date_debut] DATETIME NULL, 
    [Date_fin] DATETIME NULL, 
    CONSTRAINT [PK_Indisponibilite] PRIMARY KEY ([IdIndisponible]) 
)

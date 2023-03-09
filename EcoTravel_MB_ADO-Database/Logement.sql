CREATE TABLE [dbo].[Logement]
(
	[IdLogement] INT NOT NULL, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prix] FLOAT NOT NULL, 
    [Adresse_CP] NVARCHAR(50) NOT NULL, 
    [Adresse_Num] NVARCHAR(10) NOT NULL, 
    [Adresse_Rue] NVARCHAR(50) NOT NULL, 
    [Adresse_Pays] NVARCHAR(50) NOT NULL, 
    [Geo_Latitude] DECIMAL(10,7) NOT NULL, 
    [Geo_Longitude] DECIMAL(10,7) NOT NULL, 
    [Description_Courte] NVARCHAR(50) NOT NULL, 
    [Description_Longue] NVARCHAR(MAX) NULL, 
    [Nombre_Chambres] SMALLINT NULL, 
    [Nombre_Pieces] SMALLINT NULL, 
    [Capacity_NbreMaxPersonnes] INT NOT NULL, 
    [Nbre_SDB] TINYINT NOT NULL, 
    [Nbre_WC] TINYINT NOT NULL, 
    [Balcon] BIT NOT NULL, 
    [Air_Conditionning] BIT NOT NULL, 
    [Wifi] BIT NOT NULL, 
    [Mini_Bar] BIT NOT NULL, 
    [Animaux_accepted] BIT NOT NULL, 
    [Piscine] BIT NOT NULL, 
    [Voiturier] BIT NOT NULL, 
    [Room_Service] BIT NOT NULL,

    [Type] NVARCHAR(50) NOT NULL, 
    [IdClient] INT NOT NULL, 
    [IdPhoto] INT NOT NULL, 
    CONSTRAINT [PK_Logement] PRIMARY KEY ([idLogement]), 
    CONSTRAINT [FK_Logement_Client] FOREIGN KEY ([IdClient]) REFERENCES [Owner]([IdClient]) 
   
)

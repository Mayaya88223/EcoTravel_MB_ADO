CREATE TABLE [dbo].[Logement]
(
	[IdLogement] INT NOT NULL IDENTITY (1,1), 
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
    [Nbre_SDB] TINYINT NOT NULL DEFAULT 0, 
    [Nbre_WC] TINYINT NOT NULL DEFAULT 1, 
    [Balcon] BIT NOT NULL DEFAULT 0, 
    [Air_Conditionning] BIT NOT NULL DEFAULT 0, 
    [Wifi] BIT NOT NULL DEFAULT 0, 
    [Mini_Bar] BIT NOT NULL DEFAULT 0, 
    [Animaux_accepted] BIT NOT NULL DEFAULT 0, 
    [Piscine] BIT NOT NULL DEFAULT 0, 
    [Voiturier] BIT NOT NULL DEFAULT 0, 
    [Room_Service] BIT NOT NULL DEFAULT 0,

    [Type] NVARCHAR(50) NOT NULL, 
    [IdClient] INT NOT NULL, 
    [IdPhoto] INT NOT NULL, 
    [Date_Creation] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [PK_Logement] PRIMARY KEY ([IdLogement]), 
    CONSTRAINT [FK_Logement_Client] FOREIGN KEY ([IdClient]) REFERENCES [Owner]([IdClient]),
    CONSTRAINT [CK_Logement_Nom] CHECK (LEN([Nom]) >= 3 ),
    CONSTRAINT [CK_Logement_prixNuit] CHECK ([Prix] >= 0),
    CONSTRAINT [CK_Logement_nbChambre] CHECK ([Nombre_Chambres] >= 1),
    CONSTRAINT [CK_Logement_nbPiece] CHECK ([Nombre_Pieces] >= 1),
    CONSTRAINT [CK_Logement_capacite] CHECK ([Capacity_NbreMaxPersonnes] >= 1),
    CONSTRAINT [CK_Logement_Description] CHECK (LEN([Description_Courte]) < LEN([Description_Longue])), 
    CONSTRAINT [FK_Logement_Type_Logement] FOREIGN KEY ([Type]) REFERENCES [Type_Logement]([Type]),
)

GO

CREATE INDEX [UK_Logement_Nom] ON [dbo].[Logement] ([Nom])

GO

CREATE INDEX [UK_Logement_Geo_Latitude] ON [dbo].[Logement] ([Geo_Latitude])

GO

CREATE INDEX [UK_Logement_Geo_Longitude] ON [dbo].[Logement] ([Geo_Longitude])

CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT NOT NULL IDENTITY (1,1), 
    [Frais_Sejour] FLOAT NOT NULL, 
    [Taxe_Sejour] FLOAT NOT NULL, 
    [Assurance_annulation] BIT NOT NULL DEFAULT 0, 
    [IdAvis] INT NOT NULL,
    [IdIndisponibilite] INT NOT NULL,
    [IdLogement] INT NOT NULL,
    [IdClient] INT NOT NULL,
    [Date_debut] DATETIME NOT NULL, 
    [Date_fin] DATETIME NOT NULL, 
    [Date_resa] DATETIME NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([IdReservation]), 
    
    CONSTRAINT [FK_Reservation_Avis] FOREIGN KEY ([IdAvis]) REFERENCES [Avis]([idAvis]),
    CONSTRAINT [FK_Reservation_Indisponibilite] FOREIGN KEY ([IdIndisponibilite]) REFERENCES [Indisponibilite]([IdIndisponible]),
    CONSTRAINT [FK_Reservation_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]),
    CONSTRAINT [CK_Reservation_dateDebutDispo] CHECK ([Date_Debut] >= GETDATE()),
    CONSTRAINT [CK_Reservation_dateFinDispo] CHECK ([Date_Fin] > [Date_Debut])
)

GO

CREATE INDEX [UK_Reservation_IdReservation] ON [dbo].[Reservation] ([IdReservation])

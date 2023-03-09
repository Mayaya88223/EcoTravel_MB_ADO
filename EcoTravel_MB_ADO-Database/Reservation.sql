CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT NOT NULL, 
    [Frais_Sejour] FLOAT NOT NULL, 
    [Taxe_Sejour] FLOAT NOT NULL, 
    [Assurance_annulation] BIT NOT NULL, 
    [IdAvis] INT NOT NULL,
    [IdIndisponibilite] INT NOT NULL,
    [IdLogement] INT NOT NULL,
    [IdClient] INT NOT NULL,
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([IdReservation]), 
    
    CONSTRAINT [FK_Reservation_Avis] FOREIGN KEY ([IdAvis]) REFERENCES [Avis]([idAvis]),
    CONSTRAINT [FK_Reservation_Indisponibilite] FOREIGN KEY ([IdIndisponibilite]) REFERENCES [Indisponibilite]([IdIndisponible]),
    CONSTRAINT [FK_Reservation_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
    CONSTRAINT [FK_Reservation_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient])
)

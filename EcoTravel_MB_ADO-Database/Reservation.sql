CREATE TABLE [dbo].[Reservation]
(
	[IdReservation] INT NOT NULL, 
    [Frais_Sejour] FLOAT NOT NULL, 
    [Taxe_Sejour] FLOAT NOT NULL, 
    [Assurance_annulation] BIT NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([IdReservation]) 
)

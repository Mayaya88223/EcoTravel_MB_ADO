CREATE TABLE [dbo].[Annulation]
(
	[IdReservation] INT NOT NULL, 
    [Date_annulation] DATETIME NOT NULL, 
    [Proprio_annul] BIT NULL, 
    [IdClient] INT NOT NULL, 
    CONSTRAINT [FK_Annulation_Reservation] FOREIGN KEY ([IdReservation]) REFERENCES [Reservation]([IdReservation]), 
    CONSTRAINT [FK_Annulation_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient])
)

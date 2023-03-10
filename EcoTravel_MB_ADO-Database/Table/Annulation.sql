CREATE TABLE [dbo].[Annulation]
(
	[IdReservation] INT NOT NULL IDENTITY (1,1), 
    [Date_annulation] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Proprio_annul] BIT NULL, 
    [IdClient] INT NOT NULL, 
    CONSTRAINT [FK_Annulation_Reservation] FOREIGN KEY ([IdReservation]) REFERENCES [Reservation]([IdReservation]), 
    CONSTRAINT [FK_Annulation_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient])
   
)

CREATE TABLE [dbo].[Owner]
(
	[IdClient] INT NOT NULL,
    [IdLogement] INT NULL, 
    CONSTRAINT [FK_Owner_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [PK_Owner] PRIMARY KEY ([IdClient]), 
    CONSTRAINT [FK_Owner_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
)

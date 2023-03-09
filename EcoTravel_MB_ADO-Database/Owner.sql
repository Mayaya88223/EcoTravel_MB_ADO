CREATE TABLE [dbo].[Owner]
(
	[IdClient] INT NOT NULL,
    CONSTRAINT [FK_Owner_Client] FOREIGN KEY ([IdClient]) REFERENCES [Client]([IdClient]), 
    CONSTRAINT [PK_Owner] PRIMARY KEY ([IdClient]) 
)

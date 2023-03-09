﻿CREATE TABLE [dbo].[Type_Logement]
(
	[IdType] INT NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Type_Logement] PRIMARY KEY ([idType]), 
    CONSTRAINT [FK_Type_Logement_Logement] FOREIGN KEY ([Type]) REFERENCES [Logement]([Type]) 
)

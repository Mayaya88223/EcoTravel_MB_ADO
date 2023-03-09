CREATE TABLE [dbo].[Type_Logement]
(
	[IdType] INT NOT NULL IDENTITY (1,1), 
    [Description] NVARCHAR(50) NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Type_Logement] PRIMARY KEY ([idType]), 
    CONSTRAINT [UK_Type_Logement_Type] UNIQUE ([Type]) 
)

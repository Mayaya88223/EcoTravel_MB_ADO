CREATE TABLE [dbo].[Photo]
(
	[IdPhoto] INT NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Image] NVARCHAR(50) NULL, 

    [IdLogement] INT NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([IdPhoto]), 
    CONSTRAINT [FK_Photo_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
    
)

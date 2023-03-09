CREATE TABLE [dbo].[Photo]
(
	[IdPhoto] INT NOT NULL IDENTITY (1,1),
    [Description] NVARCHAR(50) NOT NULL, 
    [Image] NVARCHAR(50) NULL, 

    [IdLogement] INT NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([IdPhoto]), 
    CONSTRAINT [FK_Photo_Logement] FOREIGN KEY ([IdLogement]) REFERENCES [Logement]([IdLogement]),
    CONSTRAINT [CK_Photo_photo] CHECK (LEN([Description]) >= 5 AND ([Description] LIKE '%_.png' OR [Description] LIKE '%_.jpg')),
    
)

GO

CREATE INDEX [UK_Photo_Description] ON [dbo].[Photo] ([Description])

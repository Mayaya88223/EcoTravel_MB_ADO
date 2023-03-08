CREATE TABLE [dbo].[Photo]
(
	[IdPhoto] INT NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [Image] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Photo] PRIMARY KEY ([IdPhoto]) 
)

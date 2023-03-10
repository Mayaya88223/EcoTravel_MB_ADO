CREATE PROCEDURE [dbo].[SP_Annulation_Add]
	@IdReservation INT,
	@Date_annulation DATETIME,
	@Proprio_annul BIT,
	@IdClient INT
	
AS
	INSERT INTO [Annulation] ([Date_annulation],[Proprio_annul],[IdClient])
	OUTPUT [inserted].[IdReservation]
	VALUES (@Date_annulation, @Proprio_annul, @IdClient)
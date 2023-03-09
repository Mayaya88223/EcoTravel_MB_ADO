CREATE PROCEDURE [dbo].[SP_Reservations_EnCours]
    @IdClient INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT [Reservation].[IdReservation], [Logement].[Nom], [Reservation].[Date_debut], [Reservation].[Date_fin]
    FROM [Reservation]
    INNER JOIN [Logement] ON [Reservation].[IdLogement] = [Logement].[IdLogement]
    WHERE [Reservation].[IdClient] = @IdClient
    AND [Reservation].[Date_debut] <= GETDATE()
    AND [Reservation].[Date_fin] >= GETDATE();
END

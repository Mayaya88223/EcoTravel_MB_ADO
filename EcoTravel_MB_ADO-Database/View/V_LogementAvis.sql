CREATE VIEW [dbo].[V_LogementAvis] 
	AS SELECT [Logement].[IdLogement], [Logement].[Nom], AVG([Avis].[Notes]) AS [MoyenneNotes]
	FROM Logement
	INNER JOIN Reservation ON [Logement].[IdLogement] = [Reservation].[IdLogement]
	INNER JOIN Avis ON [Reservation].[IdReservation] = [Avis].[IdReservation]
	GROUP BY [Logement].[IdLogement], [Logement].[Nom]
	ORDER BY [MoyenneNotes] DESC;
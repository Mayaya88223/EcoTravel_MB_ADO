CREATE VIEW [dbo].[V_LogementAvis] 
	AS SELECT [Logement].[IdLogement], [Logement].[Nom], AVG([Avis].[Notes]) AS [MoyenneNotes]
	FROM Logement
	INNER JOIN Reservation ON [Logement].[IdLogement] = [Reservation].[IdLogement]
	INNER JOIN Avis ON [Reservation].[IdAvis] = [Avis].[IdAvis]
	GROUP BY [Logement].[IdLogement], [Logement].[Nom];
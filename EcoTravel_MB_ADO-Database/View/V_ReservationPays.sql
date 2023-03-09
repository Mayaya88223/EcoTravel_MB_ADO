CREATE VIEW [dbo].[V_ReservationPays] AS 
	SELECT R.[IdReservation], R.[Frais_Sejour], R.[Taxe_Sejour], R.[Assurance_annulation], R.[IdAvis], R.[IdIndisponibilite], R.[IdClient], L.[Adresse_Pays] AS [PaysLogement] 
	FROM Reservation AS R 
	JOIN Logement AS L ON R.IdLogement = L.IdLogement
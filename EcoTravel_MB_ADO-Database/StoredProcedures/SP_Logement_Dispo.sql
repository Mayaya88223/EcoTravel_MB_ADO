CREATE PROCEDURE [dbo].[SP_Logement_Dispo]
@Date_debut DATETIME,
@Date_fin DATETIME
AS
BEGIN
SET NOCOUNT ON;

-- Sélectionner les logements indisponibles en raison des réservations
SELECT [Indisponibilite].[IdLogement], [Indisponibilite].[Date_debut], [Indisponibilite].[Date_fin]
FROM [Reservation]
INNER JOIN [Indisponibilite] ON [Reservation].[IdLogement] = [Indisponibilite].[IdLogement]
WHERE ([Reservation].[Date_debut] BETWEEN @Date_debut AND @Date_fin)
OR ([Reservation].[Date_fin] BETWEEN @Date_debut AND @Date_fin)
OR (@Date_debut BETWEEN [Reservation].[Date_debut] AND [Reservation].[Date_fin])
OR (@Date_fin BETWEEN [Reservation].[Date_debut] AND [Reservation].[Date_fin])

UNION

-- Sélectionner les logements indisponibles en raison des annulations de réservations
SELECT [Reservation].[IdLogement], [Annulation].[Date_annulation], [Reservation].[Date_fin]
FROM [Annulation]
INNER JOIN [Reservation] ON [Annulation].[IdReservation] = [Reservation].[IdReservation]
WHERE [Annulation].[Date_annulation] BETWEEN @Date_debut AND @Date_fin

UNION


-- Sélectionner les logements indisponibles en raison des travaux effectués par les propriétaires
SELECT [Indisponibilite].[IdLogement], [Indisponibilite].[Date_debut], [Indisponibilite].[Date_fin]
FROM (([Owner] INNER JOIN Logement ON Owner.IdClient=Logement.IdLogement)
INNER JOIN [Indisponibilite] ON [Logement].[IdLogement] = [Indisponibilite].[IdLogement])
LEFT JOIN [Client] ON [Owner].[IdClient] = [Client].[IdClient]

WHERE [Owner].[IdClient] IS NULL AND [Indisponibilite].[Date_debut] BETWEEN @Date_debut AND @Date_fin



UNION

-- Sélectionner tous les logements disponibles
SELECT [Logement].[IdLogement], NULL AS [Date_debut], NULL AS [Date_fin]
FROM [Logement]
WHERE [Logement].[NonDispo] = 0
OR ([Logement].[NonDispo] = 1 AND NOT EXISTS (
SELECT 1
FROM [Indisponibilite]
WHERE [Indisponibilite].[IdLogement] = [Logement].[IdLogement]
))

ORDER BY [IdLogement], [Date_debut];

END
CREATE PROCEDURE [dbo].[SP_Logement_Added]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM [dbo].[Logement]
    WHERE DATEADD(month, DATEDIFF(month, 0, [Date_Creation]), 0) = DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0)
END

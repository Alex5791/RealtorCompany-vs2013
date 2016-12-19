CREATE PROCEDURE [dbo].[DeleteGarage] @N int AS
DELETE FROM garages
WHERE garage_id = @N 
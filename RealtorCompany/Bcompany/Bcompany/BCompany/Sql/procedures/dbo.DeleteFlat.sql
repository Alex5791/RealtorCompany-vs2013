CREATE PROCEDURE [dbo].[DeleteFlat] @N int AS
DELETE FROM flats
WHERE flat_id = @N 
CREATE PROCEDURE [dbo].[DeleteLot] @N int AS
DELETE FROM lots
WHERE lot_id = @N 
CREATE PROCEDURE [dbo].[DeleteHouse] @N int AS
DELETE FROM houses
WHERE house_id = @N 
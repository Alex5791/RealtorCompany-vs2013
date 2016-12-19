CREATE PROCEDURE [dbo].[DeleteOffice] @N int AS
DELETE FROM offices
WHERE office_id = @N 
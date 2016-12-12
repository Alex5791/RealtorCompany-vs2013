CREATE PROCEDURE [dbo].[UserIDCheck] @Login VARCHAR(20), @Password VARCHAR(20), @Role VARCHAR(20), @UserID INT OUT
AS
	SELECT @UserID = [u].[user_id] FROM [dbo].[users] AS [u]
	WHERE [u].[login] = @Login AND [u].[password] = @Password AND [u].[role] = @Role

	IF @UserID IS NULL
	SET @UserID = -1
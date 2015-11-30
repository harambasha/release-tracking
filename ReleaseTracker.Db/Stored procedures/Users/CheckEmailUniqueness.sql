CREATE PROCEDURE [dbo].[CheckEmailUniqueness]
	@Email NVARCHAR(150)
AS
	SELECT *
	FROM Users
	WHERE Email = @Email

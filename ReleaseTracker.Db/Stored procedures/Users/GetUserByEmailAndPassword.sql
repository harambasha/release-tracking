CREATE PROCEDURE [dbo].[GetUserByEmailAndPassword]
	@Email NVARCHAR(150),
	@Password NVARCHAR(100)

AS
	SELECT *
	FROM Users
	WHERE Email = @Email AND Password = @Password

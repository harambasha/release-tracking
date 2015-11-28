CREATE PROCEDURE [dbo].[InsertNewUser]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(100),
	@Password NVARCHAR(100),
	@Role NVARCHAR(100)
AS
	INSERT INTO Users(FirstName,LastName,Email,Password,Role)
				VALUES(@FirstName,@LastName,@Email,@Password,@Role)

	SELECT SCOPE_IDENTITY()
	

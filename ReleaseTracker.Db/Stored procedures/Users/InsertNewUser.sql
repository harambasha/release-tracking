CREATE PROCEDURE [dbo].[InsertNewUser]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Email NVARCHAR(100),
	@Password NVARCHAR(100),
	@RolaId BIGINT
AS
	INSERT INTO Users(FirstName,LastName,Email,Password,RolaId)
				VALUES(@FirstName,@LastName,@Email,@Password,@RolaId)

	SELECT SCOPE_IDENTITY()
	

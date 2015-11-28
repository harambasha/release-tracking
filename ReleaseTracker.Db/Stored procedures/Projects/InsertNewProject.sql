CREATE PROCEDURE [dbo].[InsertNewProject]
	@Name NVARCHAR(150),
	@Description TEXT
AS
	INSERT INTO Projects(Name,Description)
			    VALUES(@Name,@Description)
	SELECT SCOPE_IDENTITY()


CREATE PROCEDURE [dbo].[CheckProjectNameUniqueness]
	@Name NVARCHAR(150)
AS
	SELECT *
	FROM Projects
	WHERE Name = @Name


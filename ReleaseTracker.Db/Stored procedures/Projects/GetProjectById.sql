CREATE PROCEDURE [dbo].[GetProjectById]
	@Id BIGINT
AS
	SELECT *
	FROM Projects
	WHERE Id = @Id


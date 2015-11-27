CREATE PROCEDURE [dbo].[DeleteProject]
	@Id BIGINT
AS
	DELETE 
	FROM Projects
	WHERE Id = @Id

	SELECT *
	FROM Projects
	WHERE Id = @Id

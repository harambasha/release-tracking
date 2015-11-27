CREATE PROCEDURE [dbo].[UpdateProject]
	@Id BIGINT,
	@Name NVARCHAR(150),
	@Description TEXT
AS
	UPDATE Projects
	SET Name = @Name,
		Description = @Description
	WHERE Id = @Id

	/*To be sure that the project is updated*/
	SELECT *
	FROM Projects
	WHERE Id = @Id



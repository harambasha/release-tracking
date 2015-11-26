CREATE TABLE [dbo].[Projects](
	[Id] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Description] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



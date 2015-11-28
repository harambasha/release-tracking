﻿CREATE TABLE [dbo].[Features]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(150) NOT NULL,
	Description TEXT,
	Approved BIT NOT NULL,
	ReleaseId  BIGINT FOREIGN KEY REFERENCES Releases(Id) NOT NULL
)

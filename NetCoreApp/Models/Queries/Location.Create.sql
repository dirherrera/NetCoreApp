﻿CREATE TABLE [Location] (
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Name] VARCHAR(125) NOT NULL,
	[Address] VARCHAR(500) NOT NULL
)
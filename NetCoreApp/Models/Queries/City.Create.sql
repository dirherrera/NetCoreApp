﻿CREATE TABLE [City] (
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[State] UNIQUEIDENTIFIER NOT NULL,
	[Name] VARCHAR(75) NOT NULL
)
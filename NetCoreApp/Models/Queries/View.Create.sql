CREATE TABLE [View] (
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Name] VARCHAR(50) NOT NULL,
	[Controller] UNIQUEIDENTIFIER,
	[Satatus] UNIQUEIDENTIFIER NOT NULL
)
CREATE TABLE dbo.[User](
	[ID] UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	[Username] VARCHAR(30) NOT NULL,
	[Password] VARCHAR(32) NOT NULL,
	[FirstName] VARCHAR(50) NOT NULL,
	[MiddleName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(55) NOT NULL,
	[Email] VARCHAR(255) NOT NULL,
	[Created] DATETIME NOT NULL,
	[Modified] DATETIME,
	[Status] UNIQUEIDENTIFIER NOT NULL
)

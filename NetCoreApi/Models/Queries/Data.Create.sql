CREATE TABLE [Data](
	[ID] [uniqueidentifier] NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Name] [varchar](125) NOT NULL,
	[Description] [nvarchar](500) NULL
)
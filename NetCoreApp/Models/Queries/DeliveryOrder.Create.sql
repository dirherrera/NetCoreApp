﻿CREATE TABLE [DeliveryOrder] (
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Reference] VARCHAR(75) NOT NULL,
	[Customer] UNIQUEIDENTIFIER NOT NULL,
	[Vessel] UNIQUEIDENTIFIER NOT NULL,
	[Container] UNIQUEIDENTIFIER NOT NULL,
	[BL] VARCHAR(50),
	[Weight] VARCHAR(30),
	[ArrivalDate] DATETIME,
	[Created] DATETIME
)
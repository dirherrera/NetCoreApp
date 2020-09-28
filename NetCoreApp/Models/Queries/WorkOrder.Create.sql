﻿CREATE TABLE [WorkOrder] (
	[ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Reference] VARCHAR(75) NOT NULL,
	[DeliveryOrder] UNIQUEIDENTIFIER NOT NULL,
	[Created] DATETIME
)
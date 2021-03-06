﻿CREATE TABLE [dbo].[Tags] (
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	[LanguageId] UNIQUEIDENTIFIER NOT NULL,
	[TagName] NVARCHAR(100) NOT NULL,
	[CreationIp] NVARCHAR(50) NULL,
	[CreatedOn] DATETIMEOFFSET NOT NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([Id])
);
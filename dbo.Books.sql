﻿CREATE TABLE [dbo].[Books] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (MAX) NOT NULL,
	CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([Id] ASC)
);


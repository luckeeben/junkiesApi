USE [Junkies]
GO

/****** Object: Table [dbo].[Planet] Script Date: 8/8/2015 11:34:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Planet] (
    [Id]       INT            NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [SectorId] INT            NOT NULL
);



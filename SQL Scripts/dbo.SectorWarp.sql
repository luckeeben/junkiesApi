USE [Junkies]
GO

/****** Object: Table [dbo].[SectorWarp] Script Date: 8/8/2015 11:35:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SectorWarp] (
    [Id]       INT NOT NULL,
    [SectorId] INT NOT NULL,
    [WarpId]   INT NOT NULL
);



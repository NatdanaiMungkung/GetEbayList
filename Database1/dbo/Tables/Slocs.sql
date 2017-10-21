CREATE TABLE [dbo].[Slocs] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (20) NOT NULL,
    [Enable]      BIT           NOT NULL,
    [Description] NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


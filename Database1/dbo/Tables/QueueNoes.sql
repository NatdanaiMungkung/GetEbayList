CREATE TABLE [dbo].[QueueNoes] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (20) NOT NULL,
    [Enable]          BIT           NOT NULL,
    [Description]     NVARCHAR (20) NULL,
    [Transporters_Id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Transporters_Id]) REFERENCES [dbo].[Transporters] ([Id])
);


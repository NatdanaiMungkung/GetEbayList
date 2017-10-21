CREATE TABLE [dbo].[Users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (20) NOT NULL,
    [FullName] NVARCHAR (30) NOT NULL,
    [PassWord] NVARCHAR (20) NOT NULL,
    [Type]     BIT           NOT NULL,
    [Enable]   BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


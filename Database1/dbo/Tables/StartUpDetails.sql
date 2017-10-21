CREATE TABLE [dbo].[StartUpDetails] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [StartUpDatas_Id]   INT           NOT NULL,
    [Document_Types_Id] INT           NULL,
    [DocumentNo]        VARCHAR (20)  NULL,
    [Slocs_Id]          INT           NULL,
    [No_of_Item]        INT           NULL,
    [QuantityRequest]   INT           NULL,
    [IsShortShip]       BIT           NULL,
    [QuantityShort]     INT           NULL,
    [QuantityActual]    INT           NULL,
    [ReturnDoc]         NVARCHAR (20) NULL,
    [ShortShipDoc]      NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([StartUpDatas_Id]) REFERENCES [dbo].[StartUpDatas] ([Id])
);


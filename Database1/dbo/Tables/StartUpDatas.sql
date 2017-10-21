CREATE TABLE [dbo].[StartUpDatas] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [QueueNoes_Id]      INT           NULL,
    [QueueDate]         DATE          NULL,
    [QueueTime]         TIME (7)      NULL,
    [QueueExpectedDate] DATE          NULL,
    [QueueExpectedTime] TIME (7)      NULL,
    [Shipment]          NVARCHAR (20) NULL,
    [Routes_Id]         INT           NULL,
    [Truck_Types_Id]    INT           NULL,
    [TruckNo]           VARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


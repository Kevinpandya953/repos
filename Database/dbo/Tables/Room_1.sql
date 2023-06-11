CREATE TABLE [dbo].[Room] (
    [RoomId]        INT          NOT NULL,
    [BuildingId]    INT          NOT NULL,
    [RoomName]      VARCHAR (30) NOT NULL,
    [isLibrary]     BIT          NOT NULL,
    [isComputerLab] BIT          NOT NULL,
    [isOtherLab]    BIT          NOT NULL,
    [Capacity]      INT          NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomId] ASC),
    CONSTRAINT [FK_Room_Building] FOREIGN KEY ([BuildingId]) REFERENCES [dbo].[Building] ([BuildingId])
);


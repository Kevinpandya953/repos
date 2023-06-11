CREATE TABLE [dbo].[Building] (
    [BuildingId]       INT          NOT NULL,
    [CampusId]         INT          NOT NULL,
    [BuildingName]     VARCHAR (30) NOT NULL,
    [NoOfRooms]        INT          NOT NULL,
    [NoOfMeetingHalls] INT          NOT NULL,
    [isLibrary]        BIT          NOT NULL,
    [NoOfComputerLabs] INT          NOT NULL,
    [NoOfTerminals]    INT          NOT NULL,
    CONSTRAINT [PK_Building] PRIMARY KEY CLUSTERED ([BuildingId] ASC),
    CONSTRAINT [FK_Building_Campus] FOREIGN KEY ([CampusId]) REFERENCES [dbo].[Campus] ([CampusId])
);


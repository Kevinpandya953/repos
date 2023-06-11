CREATE TABLE [dbo].[Faculty] (
    [FacultyId]     INT          NOT NULL,
    [ProgramId]     INT          NOT NULL,
    [FirstName]     VARCHAR (50) NOT NULL,
    [LastName]      VARCHAR (50) NOT NULL,
    [DOB]           DATE         NOT NULL,
    [CountryId]     INT          NOT NULL,
    [StateId]       INT          NOT NULL,
    [CityId]        INT          NOT NULL,
    [StreetName]    VARCHAR (50) NOT NULL,
    [PhoneNo]       INT          NOT NULL,
    [DesignationId] INT          NOT NULL,
    [UserId]        INT          NOT NULL,
    CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED ([FacultyId] ASC),
    CONSTRAINT [FK_Faculty_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId]),
    CONSTRAINT [FK_Faculty_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId]),
    CONSTRAINT [FK_Faculty_Designation] FOREIGN KEY ([DesignationId]) REFERENCES [dbo].[Designation] ([DesignationId]),
    CONSTRAINT [FK_Faculty_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId]),
    CONSTRAINT [FK_Faculty_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);


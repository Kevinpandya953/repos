CREATE TABLE [dbo].[Student] (
    [StudentId]  INT          NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [CityId]     INT          NOT NULL,
    [StateId]    INT          NOT NULL,
    [CountryId]  INT          NOT NULL,
    [StreetName] VARCHAR (50) NOT NULL,
    [DOB]        DATE         NOT NULL,
    [PhoneNo]    INT          NOT NULL,
    [ProgramId]  INT          NOT NULL,
    [UserId]     INT          NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([StudentId] ASC),
    CONSTRAINT [FK_Student_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId]),
    CONSTRAINT [FK_Student_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId]),
    CONSTRAINT [FK_Student_DegreeProgram] FOREIGN KEY ([ProgramId]) REFERENCES [dbo].[DegreeProgram] ([DegreeProgramId]),
    CONSTRAINT [FK_Student_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId]),
    CONSTRAINT [FK_Student_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);


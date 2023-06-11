CREATE TABLE [dbo].[Campus] (
    [CampusId]     INT          NOT NULL,
    [UniversityId] INT          NOT NULL,
    [CityId]       INT          NOT NULL,
    [StateId]      INT          NOT NULL,
    [CountryId]    INT          NOT NULL,
    [StreetName]   VARCHAR (30) NOT NULL,
    [PinCode]      INT          NOT NULL,
    [Website]      VARCHAR (50) NOT NULL,
    [CampusLogo]   IMAGE        NOT NULL,
    CONSTRAINT [PK_Campus] PRIMARY KEY CLUSTERED ([CampusId] ASC),
    CONSTRAINT [FK_Campus_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId]),
    CONSTRAINT [FK_Campus_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId]),
    CONSTRAINT [FK_Campus_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId]),
    CONSTRAINT [FK_Campus_University] FOREIGN KEY ([UniversityId]) REFERENCES [dbo].[University] ([UniversityId])
);


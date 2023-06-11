CREATE TABLE [dbo].[University] (
    [UniversityId]   INT          NOT NULL,
    [UniversityName] VARCHAR (50) NOT NULL,
    [CountryId]      INT          NOT NULL,
    [StateId]        INT          NOT NULL,
    [CityId]         INT          NOT NULL,
    [StreetName]     VARCHAR (30) NOT NULL,
    [PinCode]        INT          NOT NULL,
    [Website]        VARCHAR (50) NOT NULL,
    [Logo]           IMAGE        NOT NULL,
    CONSTRAINT [PK_University] PRIMARY KEY CLUSTERED ([UniversityId] ASC),
    CONSTRAINT [FK_University_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId]),
    CONSTRAINT [FK_University_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId]),
    CONSTRAINT [FK_University_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId])
);


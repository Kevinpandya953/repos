CREATE TABLE [dbo].[Country] (
    [CountryId]   INT          NOT NULL,
    [CountryName] VARCHAR (30) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);


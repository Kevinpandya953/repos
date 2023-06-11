CREATE TABLE [dbo].[State] (
    [StateId]   INT          NOT NULL,
    [CountryId] INT          NOT NULL,
    [StateName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([StateId] ASC),
    CONSTRAINT [FK_State_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([CountryId])
);


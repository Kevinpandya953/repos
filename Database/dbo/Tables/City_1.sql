CREATE TABLE [dbo].[City] (
    [CityId]   INT          NOT NULL,
    [StateId]  INT          NOT NULL,
    [CityName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([CityId] ASC),
    CONSTRAINT [FK_City_State] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId])
);


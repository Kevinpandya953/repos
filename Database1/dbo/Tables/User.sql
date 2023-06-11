CREATE TABLE [dbo].[User] (
    [UserId]   INT          NOT NULL,
    [Username] VARCHAR (20) NOT NULL,
    [Password] VARCHAR (30) NOT NULL,
    [Mail]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);


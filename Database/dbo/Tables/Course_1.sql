CREATE TABLE [dbo].[Course] (
    [CourseId]     INT          NOT NULL,
    [CourseName]   VARCHAR (30) NOT NULL,
    [CourseCredit] INT          NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([CourseId] ASC)
);


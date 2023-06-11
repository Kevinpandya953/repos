CREATE TABLE [dbo].[Semester] (
    [SemesterId]     INT NOT NULL,
    [YearOfSemester] INT NOT NULL,
    [SemesterNo]     INT NOT NULL,
    [SemesterYear]   INT NULL,
    CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED ([SemesterId] ASC)
);


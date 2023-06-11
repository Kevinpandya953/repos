CREATE TABLE [dbo].[FeeMaster] (
    [FeeMasterId]      INT NOT NULL,
    [SemesterCourseId] INT NOT NULL,
    [FeeAmount]        INT NOT NULL,
    CONSTRAINT [PK_FeeMaster] PRIMARY KEY CLUSTERED ([FeeMasterId] ASC),
    CONSTRAINT [FK_FeeMaster_SemesterCourse] FOREIGN KEY ([SemesterCourseId]) REFERENCES [dbo].[SemesterCourse] ([SemesterCourseId])
);


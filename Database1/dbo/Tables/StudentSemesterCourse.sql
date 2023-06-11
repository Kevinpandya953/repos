CREATE TABLE [dbo].[StudentSemesterCourse] (
    [StudentSemesterCourseId] INT NOT NULL,
    [SemesterCourseId]        INT NOT NULL,
    [StudentId]               INT NOT NULL,
    CONSTRAINT [PK_StudentSemesterCourse] PRIMARY KEY CLUSTERED ([StudentSemesterCourseId] ASC),
    CONSTRAINT [FK_StudentSemesterCourse_SemesterCourse] FOREIGN KEY ([SemesterCourseId]) REFERENCES [dbo].[SemesterCourse] ([SemesterCourseId]),
    CONSTRAINT [FK_StudentSemesterCourse_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId])
);


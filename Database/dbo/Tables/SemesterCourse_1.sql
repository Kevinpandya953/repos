CREATE TABLE [dbo].[SemesterCourse] (
    [SemesterCourseId] INT NOT NULL,
    [SemesterId]       INT NOT NULL,
    [CourseId]         INT NOT NULL,
    [RoomId]           INT NOT NULL,
    [FacultyId]        INT NOT NULL,
    CONSTRAINT [PK_SemesterCourse] PRIMARY KEY CLUSTERED ([SemesterCourseId] ASC),
    CONSTRAINT [FK_SemesterCourse_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId]),
    CONSTRAINT [FK_SemesterCourse_Faculty] FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculty] ([FacultyId]),
    CONSTRAINT [FK_SemesterCourse_Room] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Room] ([RoomId]),
    CONSTRAINT [FK_SemesterCourse_Semester] FOREIGN KEY ([SemesterId]) REFERENCES [dbo].[Semester] ([SemesterId])
);


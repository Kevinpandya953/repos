CREATE TABLE [dbo].[ProgramCourse] (
    [ProgramCourseId] INT NOT NULL,
    [CourseId]        INT NOT NULL,
    [ProgramId]       INT NOT NULL,
    CONSTRAINT [PK_ProgramCourse] PRIMARY KEY CLUSTERED ([ProgramCourseId] ASC),
    CONSTRAINT [FK_ProgramCourse_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId]),
    CONSTRAINT [FK_ProgramCourse_DegreeProgram] FOREIGN KEY ([ProgramId]) REFERENCES [dbo].[DegreeProgram] ([DegreeProgramId])
);


CREATE TABLE [dbo].[DegreeProgram] (
    [DegreeProgramId]   INT          NOT NULL,
    [DegreeProgramName] VARCHAR (50) NOT NULL,
    [CampusId]          INT          NOT NULL,
    [RequiredCredits]   INT          NOT NULL,
    [FacultyId]         INT          NOT NULL,
    CONSTRAINT [PK_DegreeProgram] PRIMARY KEY CLUSTERED ([DegreeProgramId] ASC),
    CONSTRAINT [FK_DegreeProgram_Campus] FOREIGN KEY ([CampusId]) REFERENCES [dbo].[Campus] ([CampusId]),
    CONSTRAINT [FK_DegreeProgram_Faculty] FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculty] ([FacultyId])
);


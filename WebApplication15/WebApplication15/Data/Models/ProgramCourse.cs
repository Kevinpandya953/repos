using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class ProgramCourse
    {
        public int ProgramCourseId { get; set; }
        public int CourseId { get; set; }
        public int ProgramId { get; set; }

        public virtual Course Course { get; set; }
        public virtual DegreeProgram Program { get; set; }
    }
}

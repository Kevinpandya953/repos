using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class Course
    {
        public Course()
        {
            ProgramCourse = new HashSet<ProgramCourse>();
            SemesterCourse = new HashSet<SemesterCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCredit { get; set; }

        public virtual ICollection<ProgramCourse> ProgramCourse { get; set; }
        public virtual ICollection<SemesterCourse> SemesterCourse { get; set; }
    }
}

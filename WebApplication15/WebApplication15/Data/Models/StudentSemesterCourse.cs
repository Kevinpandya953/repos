using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class StudentSemesterCourse
    {
        public int StudentSemesterCourseId { get; set; }
        public int SemesterCourseId { get; set; }
        public int StudentId { get; set; }

        public virtual SemesterCourse SemesterCourse { get; set; }
        public virtual Student Student { get; set; }
    }
}

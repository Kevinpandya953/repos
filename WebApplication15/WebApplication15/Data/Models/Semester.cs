using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class Semester
    {
        public Semester()
        {
            SemesterCourse = new HashSet<SemesterCourse>();
        }

        public int SemesterId { get; set; }
        public int YearOfSemester { get; set; }
        public int SemesterNo { get; set; }
        public int? SemesterYear { get; set; }

        public virtual ICollection<SemesterCourse> SemesterCourse { get; set; }
    }
}

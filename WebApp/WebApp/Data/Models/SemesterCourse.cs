using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp.Data.Models
{
    public partial class SemesterCourse
    {
        public SemesterCourse()
        {
            FeeMaster = new HashSet<FeeMaster>();
            StudentSemesterCourse = new HashSet<StudentSemesterCourse>();
        }

        public int SemesterCourseId { get; set; }
        public int SemesterId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public int FacultyId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Room Room { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual ICollection<FeeMaster> FeeMaster { get; set; }
        public virtual ICollection<StudentSemesterCourse> StudentSemesterCourse { get; set; }
    }
}

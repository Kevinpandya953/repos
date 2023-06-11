using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class FeeMaster
    {
        public int FeeMasterId { get; set; }
        public int SemesterCourseId { get; set; }
        public int FeeAmount { get; set; }

        public virtual SemesterCourse SemesterCourse { get; set; }
    }
}

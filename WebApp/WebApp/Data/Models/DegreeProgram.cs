using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp.Data.Models
{
    public partial class DegreeProgram
    {
        public DegreeProgram()
        {
            ProgramCourse = new HashSet<ProgramCourse>();
            Student = new HashSet<Student>();
        }

        public int DegreeProgramId { get; set; }
        public string DegreeProgramName { get; set; }
        public int CampusId { get; set; }
        public int RequiredCredits { get; set; }
        public int FacultyId { get; set; }

        public virtual Campus Campus { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<ProgramCourse> ProgramCourse { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp.Data.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            DegreeProgram = new HashSet<DegreeProgram>();
            SemesterCourse = new HashSet<SemesterCourse>();
        }

        public int FacultyId { get; set; }
        public int ProgramId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string StreetName { get; set; }
        public int PhoneNo { get; set; }
        public int DesignationId { get; set; }
        public int UserId { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual State State { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DegreeProgram> DegreeProgram { get; set; }
        public virtual ICollection<SemesterCourse> SemesterCourse { get; set; }
    }
}

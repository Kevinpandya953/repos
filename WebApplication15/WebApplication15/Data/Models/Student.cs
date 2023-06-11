using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentSemesterCourse = new HashSet<StudentSemesterCourse>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StreetName { get; set; }
        public DateTime Dob { get; set; }
        public int PhoneNo { get; set; }
        public int ProgramId { get; set; }
        public int UserId { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual DegreeProgram Program { get; set; }
        public virtual State State { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<StudentSemesterCourse> StudentSemesterCourse { get; set; }
    }
}

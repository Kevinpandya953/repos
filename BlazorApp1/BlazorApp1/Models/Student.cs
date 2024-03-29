﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
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
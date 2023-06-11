﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
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
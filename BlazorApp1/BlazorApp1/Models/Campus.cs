﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public partial class Campus
    {
        public Campus()
        {
            Building = new HashSet<Building>();
            DegreeProgram = new HashSet<DegreeProgram>();
        }

        public int CampusId { get; set; }
        public int UniversityId { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StreetName { get; set; }
        public int PinCode { get; set; }
        public string Website { get; set; }
        public byte[] CampusLogo { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Building> Building { get; set; }
        public virtual ICollection<DegreeProgram> DegreeProgram { get; set; }
    }
}
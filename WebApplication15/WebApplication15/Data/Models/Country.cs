using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class Country
    {
        public Country()
        {
            Campus = new HashSet<Campus>();
            Faculty = new HashSet<Faculty>();
            State = new HashSet<State>();
            Student = new HashSet<Student>();
            University = new HashSet<University>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Campus> Campus { get; set; }
        public virtual ICollection<Faculty> Faculty { get; set; }
        public virtual ICollection<State> State { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<University> University { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp.Data.Models
{
    public partial class State
    {
        public State()
        {
            Campus = new HashSet<Campus>();
            City = new HashSet<City>();
            Faculty = new HashSet<Faculty>();
            Student = new HashSet<Student>();
            University = new HashSet<University>();
        }

        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Campus> Campus { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Faculty> Faculty { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<University> University { get; set; }
    }
}

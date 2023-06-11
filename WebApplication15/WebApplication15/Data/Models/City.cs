using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class City
    {
        public City()
        {
            Campus = new HashSet<Campus>();
            Faculty = new HashSet<Faculty>();
            Student = new HashSet<Student>();
            University = new HashSet<University>();
        }

        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Campus> Campus { get; set; }
        public virtual ICollection<Faculty> Faculty { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<University> University { get; set; }
    }
}

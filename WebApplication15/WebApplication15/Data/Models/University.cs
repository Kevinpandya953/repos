using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class University
    {
        public University()
        {
            Campus = new HashSet<Campus>();
        }

        public int UniversityId { get; set; }
        public string UniversityName { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string StreetName { get; set; }
        public int PinCode { get; set; }
        public string Website { get; set; }
        public byte[] Logo { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Campus> Campus { get; set; }
    }
}

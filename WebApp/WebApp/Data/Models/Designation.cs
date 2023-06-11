using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp.Data.Models
{
    public partial class Designation
    {
        public Designation()
        {
            Faculty = new HashSet<Faculty>();
        }

        public int DesignationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Faculty> Faculty { get; set; }
    }
}

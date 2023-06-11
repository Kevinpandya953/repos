using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication15.Data.Models
{
    public partial class User
    {
        public User()
        {
            Faculty = new HashSet<Faculty>();
            Student = new HashSet<Student>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Faculty> Faculty { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}

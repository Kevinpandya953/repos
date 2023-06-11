using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Model;

namespace SchoolManager.Data
{
    public class SchoolManagerContext : DbContext
    {
        public SchoolManagerContext (DbContextOptions<SchoolManagerContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolManager.Model.Student> Student { get; set; }

        public DbSet<SchoolManager.Model.Teacher> Teacher { get; set; }
    }
}

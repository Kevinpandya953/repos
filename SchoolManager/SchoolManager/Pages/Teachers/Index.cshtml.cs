using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Data;
using SchoolManager.Model;

namespace SchoolManager.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly SchoolManager.Data.SchoolManagerContext _context;

        public IndexModel(SchoolManager.Data.SchoolManagerContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get;set; }

        public async Task OnGetAsync()
        {
            Teacher = await _context.Teacher.ToListAsync();
        }
    }
}

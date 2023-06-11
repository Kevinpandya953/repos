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
    public class DetailsModel : PageModel
    {
        private readonly SchoolManager.Data.SchoolManagerContext _context;

        public DetailsModel(SchoolManager.Data.SchoolManagerContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.id == id);

            if (Teacher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

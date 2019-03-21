using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CenterStage.Data;
using CenterStage.Data.Models;

namespace CenterStage.Pages.ClassContactList
{
    public class DetailsModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public DetailsModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public StudentRegistration StudentRegistration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).FirstOrDefaultAsync(m => m.ID == id);

            if (StudentRegistration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

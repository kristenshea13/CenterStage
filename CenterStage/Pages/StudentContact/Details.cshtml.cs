using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CenterStage.Data;
using CenterStage.Data.Models;

namespace CenterStage.Pages.StudentContact
{
    public class DetailsModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public DetailsModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public StudentInfo StudentInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentInfo = await _context.StudentInfo.FirstOrDefaultAsync(m => m.ID == id);

            if (StudentInfo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

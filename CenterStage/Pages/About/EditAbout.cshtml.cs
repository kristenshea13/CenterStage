using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CenterStage.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CenterStage.Pages.About
{
    public class EditAboutModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public EditAboutModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Data.Models.AboutModel AboutModel { get; set; }



        public async Task<IActionResult> OnGetAsync()
        {
            AboutModel = await _context.About.FirstOrDefaultAsync(m => m.ID == 1).ConfigureAwait(false);

            if (AboutModel == null)
            {
                AboutModel = new Data.Models.AboutModel { ID = 1 };
            }

            return Page();

           


        }
    }
}
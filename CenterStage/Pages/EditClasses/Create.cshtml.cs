using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CenterStage.Data;
using CenterStage.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace CenterStage.Pages.EditClasses
{
    //[Authorize(Roles = "administrator")]
    [Authorize]

    public class CreateModel : PageModel
    {
        
        private readonly CenterStage.Data.ApplicationDbContext _context;

        
        public CreateModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Class Class { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Class.Add(Class);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
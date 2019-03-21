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
    public class IndexModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public IndexModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StudentRegistration> StudentRegistration { get;set; }



        public async Task OnGetAsync()
        {
            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).ToListAsync();
        }
    }
}

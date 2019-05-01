using CenterStage.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CenterStage.Pages.ClassContactList
{
    public class IndexModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public IndexModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StudentRegistration> StudentRegistration { get; set; }

        

        public SelectList Classes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ClassTitle { get; set; }

        

        public async Task OnGetAsync()
        {
            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).ToListAsync();

            

        }
    }
}
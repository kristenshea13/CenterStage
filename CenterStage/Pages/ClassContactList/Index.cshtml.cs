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

        [BindProperty(SupportsGet = true)]
        public int? ClassID { get; set; }

        public SelectList ClassTitle { get; set; }    

        

     



        public async Task OnGetAsync()
        {

            var classes = from c in _context.Class
                          select c;

            ClassTitle = new SelectList(classes.ToList(), "ID", "Title");

            

            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).Where(s => ClassID.HasValue && 
                (ClassID == 0 || s.ClassID == ClassID.Value))
                .OrderBy(s => s.Class.Title).ToListAsync();




        }
    }
}
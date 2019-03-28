using CenterStage.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        //[BindProperty(SupportsGet = true)]
        //public string SearchString { get; set; }

        //public SelectList Titles { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string Title { get; set; }

        //public async Task OneGetAsync()
        //{
        //    var titles = from s in _context.StudentRegistration select s;

        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        titles = titles.Where(t => t.Class.Title.Contains(SearchString));
        //    }

        //    Title = await titles.ToListAsync();

        //}

        public async Task OnGetAsync()
        {
            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).ToListAsync();
        }
    }
}
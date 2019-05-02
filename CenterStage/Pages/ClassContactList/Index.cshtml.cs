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
        public string SearchString { get; set; }

        public SelectList Class { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ClassTitle { get; set; }

        //public IList<Movie> Movie { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string SearchString { get; set; }
        //// Requires using Microsoft.AspNetCore.Mvc.Rendering;
        //public SelectList Genres { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string MovieGenre { get; set; }









        public async Task OnGetAsync()
        {

            //var classes = from c in _context.Class select c;

            //if (!string.IsNullOrEmpty(SearchString))
            //{
            //    classes = classes.Where(s = s.Class.Contains(SearchString));
            //}

            //Class = await classes.ToListAsync().ConfigureAwait(false);


            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).ToListAsync();



            //    var movies = from m in _context.Movie
            //                 select m;
            //    if (!string.IsNullOrEmpty(SearchString))
            //    {
            //        movies = movies.Where(s => s.Title.Contains(SearchString));
            //    }

            //    Movie = await movies.ToListAsync();





        }
    }
}
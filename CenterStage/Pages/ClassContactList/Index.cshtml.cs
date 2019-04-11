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

        //[BindProperty(SupportsGet = true)]
        //public string SearchString { get; set; }
        //// Requires using Microsoft.AspNetCore.Mvc.Rendering;
        //public SelectList Genres { get; set; }
        //[BindProperty(SupportsGet = true)]
        //public string MovieGenre { get; set; }

        public SelectList Classes { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ClassTitle { get; set; }

        //        IQueryable<string> genreQuery = from m in _context.Movie
        //                                        orderby m.Genre
        //                                        select m.Genre;

        //        var movies = from m in _context.Movie
        //                     select m;

        //            if (!string.IsNullOrEmpty(SearchString))
        //            {
        //                movies = movies.Where(s => s.Title.Contains(SearchString));
        //            }

        //            if (!string.IsNullOrEmpty(MovieGenre))
        //            {
        //                movies = movies.Where(x => x.Genre == MovieGenre);
        //            }
        //Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
        //Movie = await movies.ToListAsync();

        public async Task OnGetAsync()
        {
            StudentRegistration = await _context.StudentRegistration
                .Include(s => s.Class)
                .Include(s => s.Student).ToListAsync();

            //IQueryable<string> genreQuery = (IQueryable<string>)(from c in _context.StudentRegistration
            //                                orderby c.Class
            //                                select c.Class);

            //var classes = from c in _context.StudentRegistration
            //             select c;



            //if (!string.IsNullOrEmpty(ClassTitle))
            //{
            //    classes = classes.Where(x => x.Class.ToString() == ClassTitle);
            //}

            //StudentRegistration = await classes.ToListAsync();

            //StudentRegistration = await _context.StudentRegistration.Include(c => c.Student).ToListAsync();

        }
    }
}
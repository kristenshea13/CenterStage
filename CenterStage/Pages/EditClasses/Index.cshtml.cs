using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CenterStage.Data;
using CenterStage.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace CenterStage.Pages.EditClasses
{
    [Authorize]
    
    public class IndexModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public IndexModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Titles { get; set; }
        public SelectList Prerequisites { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ClassTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ClassPrerequisite { get; set; }

        public async Task OnGetAsync()
        {



            IQueryable<string> prerequisiteQuery = from c in _context.Class
                                                   orderby c.Prerequisite
                                                   select c.Prerequisite;

            var classes = from c in _context.Class
                          select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                classes = classes.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ClassPrerequisite))
            {
                classes = classes.Where(x => x.Prerequisite == ClassPrerequisite);
            }

            Prerequisites = new SelectList(await prerequisiteQuery.Distinct().ToListAsync());
            Class = await classes.ToListAsync();

        }

        }
    }

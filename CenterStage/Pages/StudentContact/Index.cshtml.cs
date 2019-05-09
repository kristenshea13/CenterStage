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
    public class IndexModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public IndexModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StudentInfo> StudentInfo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync()
        {
            var studentinfo = from s in _context.StudentInfo
                              //where s.UserName added
                              where s.UserName == User.Identity.Name
                              select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                studentinfo = studentinfo.Where(x => x.StudentName.Contains(SearchString));
            }



            StudentInfo = await studentinfo.ToListAsync();






        }
    }
}

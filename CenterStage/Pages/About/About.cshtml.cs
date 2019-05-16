﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CenterStage.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CenterStage.Pages.About
{
    public class AboutModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public AboutModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        //public IActionResult OnGet()
        //{
        //    return Page();
        //}


        //[BindProperty]
        //public string MissionStmt { get; set; }

        //[BindProperty]
        //public string AboutStudio { get; set; }

        public int ID { get; set; }

        [BindProperty]
        public List<Data.Models.AboutModel> About { get; set; }

        

        public async Task OnGetAsync()
        {
            About = await _context.About.ToListAsync();


        }
    }
}
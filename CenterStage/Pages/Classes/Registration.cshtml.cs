using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CenterStage.Pages.Classes
{
    [Authorize]

    public class RegistrationModel : PageModel
    {
        private readonly CenterStage.Data.ApplicationDbContext _context;

        public RegistrationModel(CenterStage.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty, Required]
        public int StudentID { get; set; }

        public SelectList Students { get; set; }

        public string ClassTitle { get; set; }

        public IActionResult OnGet(int? id)
        {
            var students = _context.StudentInfo.ToDictionary(y => y.ID, y => y.StudentName);
            Students = new SelectList(students, "Key", "Value");

            if (id == null)
            {
                return NotFound();
            }

            var classobject = _context.Class.FirstOrDefault(m => m.ID == id);

            if (classobject == null)
            {
                return NotFound();
            }

            ClassTitle = classobject.Title;

            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!_context.StudentRegistration.Any(x => x.ClassID == id && x.StudentID == StudentID))
            {
                _context.StudentRegistration.Add(new Data.Models.StudentRegistration
                { StudentID = StudentID, ClassID = id.GetValueOrDefault() });
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
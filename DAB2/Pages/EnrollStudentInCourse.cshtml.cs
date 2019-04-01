using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAB2.Database;

namespace DAB2.Pages
{
    public class EnrollStudentInCourseModel : PageModel
    {
        private readonly AppDbContext _db;

        public EnrollStudentInCourseModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public CourseStudent CourseStudent { get; set; }

        public void OnGet()
        {
            //not used.
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Add object of Student to database & save changes.

            try
            {
                _db.Add(CourseStudent);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return RedirectToPage("/Index");
                throw;
            }
            
            
            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}
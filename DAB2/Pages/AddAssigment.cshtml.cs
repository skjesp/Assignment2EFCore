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
    public class AddAssignmentModel : PageModel
    {
        private readonly AppDbContext _db;

        public AddAssignmentModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Assignment Assignment { get; set; }

        [BindProperty]
        public inputmodel Input { get; set; }

        public class inputmodel
        {
            public int courseid { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var course = _db.Courses.Single(s => s.Id.Equals(Input.courseid));

            //Add object to database & save changes.
            _db.Assignments.Add(Assignment);
            //Add object of CourseStudent to database & save changes.
            _db.Add(new CourseAssignment
            {
                Course = course,
                CourseId = course.Id,
                Assignment = Assignment,
                AssignmentId = Assignment.Id,
                Active = true
            });
            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}

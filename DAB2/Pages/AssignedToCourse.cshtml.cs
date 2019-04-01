using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using DAB2.Database;


namespace DAB2.Pages
{
    public class AssignedToCourseModel : PageModel
    {
        private readonly AppDbContext _db;

        public AssignedToCourseModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public inputmodel input
        {
            get; set;
        }

        public class inputmodel
        {
            public int CourseID { get; set; }
        }

        public void OnGet()
        {

        }

        public List<Student> Students { get; set; }
        public List<CourseTeacher> Teachers { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            foreach (var course in _db.CourseTeachers.ToList())
            {
                if (course.CourseId == input.CourseID)
                {
                    Teachers.Add(course);
                }
            }
            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}
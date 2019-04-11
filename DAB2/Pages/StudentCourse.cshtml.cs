using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAB2.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Pages
{
    public class StudentCourseModel : PageModel
    {
        private readonly AppDbContext _db;

        public StudentCourseModel(AppDbContext db)
        {
            _db = db;
            CourseStudents = new List<CourseStudent>();
        }

        public List<CourseStudent> CourseStudents { get; set; }
       
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string searchString { get; set; }
        }

        //Search students by AU-id and get Courses with status and grade.
        public async Task<IActionResult> OnPostAsync()
        {
            var courseStudents = from sc in _db.CourseStudents
                select sc;
        
            if (!string.IsNullOrEmpty(Input.searchString))
            {
                courseStudents = courseStudents.Where(s => s.Student.AuId.Contains(Input.searchString));

                //Check if we found anyting
                if (courseStudents.AsNoTracking().ToList().Count != 0)
                {
                    //Succes found a match

                } else {

                    //Failed no match reload page - Show all.
                    return RedirectToPage();
                }

            } else {

                //Do nothing if no search-string id entered.
            }
            //Load list of StudentGroups
            CourseStudents = await courseStudents.AsNoTracking().Include(cs => cs.Student).Include(cs => cs.Course).ToListAsync();

        //Update current page.
        return Page();
        }
    }
}

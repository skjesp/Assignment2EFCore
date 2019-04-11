using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using DAB2.Database;
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace DAB2.Pages
{
    public class AssignedToCourseModel : PageModel
    {
        private readonly AppDbContext _db;

        public AssignedToCourseModel(AppDbContext db)
        {
            _db = db;
            CourseTeachers = new List<CourseTeacher>();
            CourseStudent = new List<CourseStudent>();
        }

        [BindProperty]
        public inputmodel Input
        {
            get; set;
        }

        public class inputmodel
        {
            public string searchString { get; set; }
        }

        public List<CourseTeacher> CourseTeachers { get; set; }

        public List<CourseStudent> CourseStudent { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var courseteacher = from tr in _db.CourseTeachers
                select tr;

            if (!string.IsNullOrEmpty(Input.searchString))
            {
                courseteacher = courseteacher.Where(s => s.Course.Name.Contains(Input.searchString));
                //Check if we found anyting
                if (courseteacher.AsNoTracking().ToList().Count != 0)
                {
                    //Succes found a match
                }
                else
                {
                    //Failed no match reload page - Show all.
                }
            }
            else
            {
                //Do nothing if no search-string id entered.
            }
            //Load list of StudentGroups
            CourseTeachers = await courseteacher.AsNoTracking().Include(s=>s.Course).Include(s=>s.Teacher).ToListAsync();



            var coursestudent = from st in _db.CourseStudents
                select st;

            if (!string.IsNullOrEmpty(Input.searchString))
            {
                coursestudent = coursestudent.Where(s => s.Course.Name.Contains(Input.searchString));
                //Check if we found anyting
                if (coursestudent.AsNoTracking().ToList().Count != 0)
                {
                    //Succes found a match
                }
                else
                {
                    //Failed no match reload page - Show all.
                }
            }
            else
            {
                //Do nothing if no search-string id entered.
            }
            //Load list of StudentGroups
            CourseStudent = await coursestudent.AsNoTracking().Include(s=>s.Student).Include(s=>s.Course).ToListAsync();
            return Page();
        }
    }
}
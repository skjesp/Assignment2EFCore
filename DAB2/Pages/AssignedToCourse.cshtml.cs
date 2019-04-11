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
            Teachers=new List<CourseTeacher>();
            Students=new List<CourseStudent>();
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

        public List<CourseStudent> Students { get; set; }
        public List<CourseTeacher> Teachers { get; set; }


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
                    return RedirectToPage();
                }
            }
            else
            {
                //Do nothing if no search-string id entered.
            }
            //Load list of StudentGroups
            Teachers = await courseteacher.AsNoTracking().ToListAsync();

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
                    return RedirectToPage();
                }
            }
            else
            {
                //Do nothing if no search-string id entered.
            }
            //Load list of StudentGroups
            Students = await coursestudent.AsNoTracking().ToListAsync();
            return Page();
        }
    }
}
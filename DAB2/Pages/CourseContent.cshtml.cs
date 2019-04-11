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
    public class CourseContentModel : PageModel
    {
        private readonly AppDbContext _db;

        public CourseContentModel(AppDbContext db)
        {
            _db = db;
            Contents = new List<Content>();
        }

        public List<Content> Contents { get; set; }
       
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string searchString { get; set; }
        }

        //Search students by AU-id and get Courses with status and grade.
        public async Task<IActionResult> OnPostAsync()
        {
            var courseContent = from cts in _db.Content
                select cts;
                    
            if (!string.IsNullOrEmpty(Input.searchString))
            {
                courseContent = courseContent.Where(s => s.Course.Name.Contains(Input.searchString));

                //Check if we found anyting
                if (courseContent.AsNoTracking().ToList().Count != 0)
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
            Contents = await courseContent.AsNoTracking().ToListAsync();

        //Update current page.
        return Page();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAB2.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAB2.Pages
{
    public class CourseContentModel : PageModel
    {
        private readonly AppDbContext _db;
        public CourseContentModel(AppDbContext db)
        {
            _db = db;
            contents = new List<Content>();
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

        public List<Content> contents { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            foreach (var course in _db.Contents.ToList())
            {
                if (course.CourseId == input.CourseID)
                {
                    contents.Add(course);
                }
            }
            //Redirect to /Index page.
            return RedirectToPage("/CourseContent");
        }
    }
}
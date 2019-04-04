using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DAB2.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DAB2.Pages
{
    public class StudentIDModel : PageModel
    {
        private readonly AppDbContext _db;

        public StudentIDModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public inputModel input
        {
            get; set;
        }
        public class inputModel {
            public int StudentID{get; set;}
        }

        public List<enrolment> enrolments { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            foreach (var ting in _db.enrolment.toList())
            {
                if (ting.studentID == input.StudentID)
                {
                    enrolments.Add(ting);
                }
            }
            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }

        public void OnGet()
        {


            //}
        }
}
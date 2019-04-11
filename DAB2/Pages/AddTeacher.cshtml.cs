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
    public class AddTeacherModel : PageModel
    {
        private readonly AppDbContext _db;

        public AddTeacherModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Teacher Teacher { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //Add object to database & save changes.
            _db.Teachers.Add(Teacher);
            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}

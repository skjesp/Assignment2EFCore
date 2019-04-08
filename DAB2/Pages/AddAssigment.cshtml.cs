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

        public async Task OnGetAsync()
        {
            //No usage.
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //Add object to database & save changes.
            _db.Assignments.Add(Assignment);
            await _db.SaveChangesAsync();

            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}

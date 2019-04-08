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
    public class AddGroupModel : PageModel
    {
        private readonly AppDbContext _db;

        public AddGroupModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Group Group { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //Add object to database & save changes.
            _db.Groups.Add(Group);
            await _db.SaveChangesAsync();

            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAB2.Database;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DAB2.Pages
{
    public class AssignStudenToGroupModel : PageModel
    {
        private readonly AppDbContext _db;

        public AssignStudenToGroupModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public StudentGroup StudentGroup { get; set; }

        public List<SelectListItem> listStudents { get; set; }

        public List<SelectListItem> listGroups { get; set; }

        public void OnGet()
        {
            List<SelectListItem> listStudent = new List<SelectListItem>();   
            foreach (var student in _db.Students)
            {
                listStudent.Add(new SelectListItem() { Value = student.Id.ToString(), Text = student.AuId });
            }
            listStudents = listStudent;

            List<SelectListItem> listGroup = new List<SelectListItem>();  
            foreach (var group in _db.Groups)
            {
                listGroup.Add(new SelectListItem() { Value = group.Id.ToString(), Text = group.GroupNr.ToString() });
            }
            listGroups = listGroup;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var student = _db.Students.Single(s => s.Id.Equals(StudentGroup.StudentId));

            var group = _db.Groups.Single(g => g.Id == StudentGroup.GroupId);

            student.GroupNr = group.GroupNr.ToString();

            //Add object to database & save changes.
            _db.StudentGroups.Add(StudentGroup);
            await _db.SaveChangesAsync();

            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}

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
    public class GradeAssignmentModel : PageModel
    {
        private readonly AppDbContext _db;

        public GradeAssignmentModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public GroupAssignment GroupAssignment { get; set; }

        public List<SelectListItem> listGroups { get; set; }

        public List<SelectListItem> listAssignments { get; set; }

        public List<SelectListItem> listGrades { get; set; }

        public void OnGet()
        {
            List<SelectListItem> listGroup = new List<SelectListItem>();   
            foreach (var group in _db.Groups)
            {
                listGroup.Add(new SelectListItem() { Value = group.GroupId.ToString(), Text = group.GroupId.ToString() });
            }
            listGroups = listGroup;

            List<SelectListItem> listAssignment = new List<SelectListItem>();  
            foreach (var assignment in _db.Assignments)
            {
                listAssignment.Add(new SelectListItem() { Value = assignment.AssignmentId.ToString(), Text = assignment.Name });
            }
            listAssignments = listAssignment; 

            List<SelectListItem> listGrade = new List<SelectListItem>();
            listGrade.Add(new SelectListItem() { Value = "-3", Text = "-3"});
            listGrade.Add(new SelectListItem() { Value = "00", Text = "00"});
            listGrade.Add(new SelectListItem() { Value = "02", Text = "02"});
            listGrade.Add(new SelectListItem() { Value = "4", Text = "4"});
            listGrade.Add(new SelectListItem() { Value = "7", Text = "7"});
            listGrade.Add(new SelectListItem() { Value = "10", Text = "10"});
            listGrade.Add(new SelectListItem() { Value = "12", Text = "12"});

            listGrades = listGrade;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            //Add object to database & save changes.
            _db.GroupAssignments.Add(GroupAssignment);
            await _db.SaveChangesAsync();

            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}

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
    public class AssignGroupToAssignmentModel : PageModel
    {
        private readonly AppDbContext _db;

        public AssignGroupToAssignmentModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public GroupAssignment GroupAssignment{ get; set; }

        public List<SelectListItem> listGroups { get; set; }

        public List<SelectListItem> listAssignments { get; set; }


        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int groupId { get; set; }

            public int assignmentId { get; set; }
        }

        public void OnGet()
        {
            List<SelectListItem> listGroup = new List<SelectListItem>();
            foreach (var group in _db.Groups)
            {
                listGroup.Add(new SelectListItem() { Value = group.Id.ToString(), Text = group.GroupNr.ToString() });
            }
            listGroups = listGroup;

            List<SelectListItem> listAssignment = new List<SelectListItem>();
            foreach (var assignment in _db.Assignments)
            {
                listAssignment.Add(new SelectListItem() { Value = assignment.Id.ToString(), Text = assignment.Name });
            }
            listAssignments = listAssignment;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var group = _db.Groups.Single(s => s.Id.Equals(Input.groupId));

            var assingment = _db.Assignments.Single(g => g.Id.Equals(Input.assignmentId));

            //Add object to database & save changes.
            _db.GroupAssignments.Add(new GroupAssignment
            {
                GroupId = Input.groupId,
                Group = group,
                AssignmentId = Input.assignmentId,
                Assignment = assingment,
                Grade = null,
                Teacher = null
            });
            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}

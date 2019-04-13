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

        public List<SelectListItem> listTeachers { get; set; }


        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int groupId { get; set; }

            public int assignmentId { get; set; }

            public int teacherId { get; set; }
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

            List<SelectListItem> listTeacher = new List<SelectListItem>();
            foreach (var teacher in _db.Teachers)
            {
                listTeacher.Add(new SelectListItem() { Value = teacher.Id.ToString(), Text = teacher.AuId });
            }
            listTeachers = listTeacher;
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

            var teacher = _db.Teachers.Single(t => t.Id.Equals(Input.teacherId));

            //Add object to database & save changes.
            _db.GroupAssignments.Add(new GroupAssignment
            {
                GroupId = Input.groupId,
                Group = group,
                AssignmentId = Input.assignmentId,
                Assignment = assingment,
                Grade = null,
                TeacherId = Input.teacherId,
                Teacher = teacher
            });

            //Exceptionhandling - Presumed that user is trying to duplicate
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return RedirectToPage("/ErrorPage_Duplication");
            }

            return RedirectToPage();
        }
    }
}

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

        public GroupAssignment GroupAssignment { get; set; }

        public List<SelectListItem> listGroups { get; set; }

        public List<SelectListItem> listAssignments { get; set; }

        public List<SelectListItem> listGrades { get; set; }

        public List<SelectListItem> listTeachers { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int groupId { get; set; }

            public int assignmentId { get; set; }

            public string grade { get; set; }

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

            List<SelectListItem> listGrade = new List<SelectListItem>();
            listGrade.Add(new SelectListItem() { Value = "-3", Text = "-3"});
            listGrade.Add(new SelectListItem() { Value = "00", Text = "00"});
            listGrade.Add(new SelectListItem() { Value = "02", Text = "02"});
            listGrade.Add(new SelectListItem() { Value = "4", Text = "4"});
            listGrade.Add(new SelectListItem() { Value = "7", Text = "7"});
            listGrade.Add(new SelectListItem() { Value = "10", Text = "10"});
            listGrade.Add(new SelectListItem() { Value = "12", Text = "12"});

            listGrades = listGrade;

            List<SelectListItem> listTeacher = new List<SelectListItem>();   
            foreach (var teacher in _db.Teachers)
            {
                listTeacher.Add(new SelectListItem() { Value = teacher.Id.ToString(), Text = teacher.Name });
            }
            listTeachers = listTeacher;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var group = _db.Groups.Single(g => g.Id.Equals(Input.groupId));
            var assignment = _db.Assignments.Single(a => a.Id.Equals(Input.assignmentId));
            var teacher = _db.Teachers.Single(t => t.Id.Equals(Input.teacherId));

            //Add object to database & save changes.
            _db.GroupAssignments.Add(new GroupAssignment{
                GroupId = Input.groupId,
                Group = group,
                AssignmentId = Input.assignmentId,
                Assignment = assignment,
                Grade = Input.grade,
                TeacherId = Input.teacherId,
                Teacher = teacher
            });
            
            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}

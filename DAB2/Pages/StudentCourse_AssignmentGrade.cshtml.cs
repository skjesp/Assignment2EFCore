using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DAB2.Database;
using Microsoft.EntityFrameworkCore;

namespace DAB2.Pages
{
    public class StudentCourse_AssignmentGradeModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<StudentGroup> StudentGroups;
        public List<GroupAssignment> GroupAssignments;
        public List<GroupAssignment> result;

        public StudentCourse_AssignmentGradeModel(AppDbContext db)
        {
            _db = db;
            StudentGroups = new List<StudentGroup>();
            GroupAssignments = new List<GroupAssignment>();
        }

        //Databind to cshtml
        [BindProperty] public InputModel Input { get; set; }

        public class InputModel
        {
            public string searchAUID { get; set; }
            public string searchCourseID { get; set; }
        }


        //Searchresult
        public async Task<IActionResult> OnPostAsync()
        {
            //Reset result
            result = new List<GroupAssignment>();

            //Select database elements
            var courseAssignment = from el in _db.CourseAssignments select el;
            var studentGroups = from el in _db.StudentGroups select el;
            var groupAssignment = from el in _db.GroupAssignments select el;

            //Checks if user has filled forms for submit.
            if (!(string.IsNullOrEmpty(Input.searchAUID) && string.IsNullOrEmpty(Input.searchCourseID)))
            {
                //Filter elements from dataset. AUID enrolled courseID left.
                studentGroups = studentGroups.Where(s => s.Student.AuId.Equals(Input.searchAUID));
                courseAssignment = courseAssignment.Where(s => s.Course.Name.Equals(Input.searchCourseID));
                foreach (var group in studentGroups)
                {
                    foreach (var assignment in courseAssignment)
                    {
                        groupAssignment = groupAssignment.Where(s => s.Group.GroupNr.Equals(group.Group.GroupNr) && s.Assignment.Id.Equals(assignment.Assignment.Id));
                    }
                }
                if (groupAssignment.AsNoTracking().ToList().Count != 0)
                {
                    //Succes found a match
                }
                else
                {
                    //Failed no match reload page - Show all.
                }
                
                
            }
            else
            {
                //do nothing
            }

            GroupAssignments = await groupAssignment.AsNoTracking().Include(s => s.Teacher).Include(s => s.Assignment).ToListAsync();
            return Page();
        }
        public void OnGet()
        {

        }
    }
}
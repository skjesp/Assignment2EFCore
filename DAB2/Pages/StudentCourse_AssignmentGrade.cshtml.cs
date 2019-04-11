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
        public IActionResult OnPost()
        {
            //Reset result
            result = new List<GroupAssignment>();

            //Select database elements
            var courseStudents = from el in _db.CourseStudents select el;
            var studentGroups = from el in _db.StudentGroups select el;
            var groupAssignment = from el in _db.GroupAssignments select el;

            //Checks if user has filled forms for submit.
            if (!(string.IsNullOrEmpty(Input.searchAUID) && string.IsNullOrEmpty(Input.searchCourseID)))
            {
                //Filter elements from dataset. AUID enrolled courseID left.
                courseStudents = courseStudents.Where(s =>
                    s.Student.AuId.Contains(Input.searchAUID) && s.Course.Name.Equals(Input.searchCourseID));

                //Filter groups. Only groups where AUID participate left.
                studentGroups = studentGroups.Where(s => s.Student.AuId.Contains(Input.searchAUID));

                //Find appropriate assignments
                foreach (var GroupNumber in studentGroups)
                {
                    List<GroupAssignment> newInputs =
                        groupAssignment.Where(s => s.Group.GroupNr.Equals(GroupNumber.Group.GroupNr)).ToList();
                    //result.Concat(newInputs);
                    result.AddRange(newInputs);
                }


                ////Check if we found anyting
                //if (courseStudents.AsNoTracking().ToList().Count != 0)
                //{
                //    //Succes found a match


                //}
                //else
                //{
                //    //Failed no match reload page - Show all.
                //    return RedirectToPage();
                //}
                //}
                //else
                //{
                //    //Do nothing if no search-string id entered.
                //}
                //Load list of StudentGroups
                //CourseStudents = await courseStudents.AsNoTracking().ToListAsync();

                //Update current page.
                
            }
            return Page();
        }
        public void OnGet()
        {

        }
    }
}
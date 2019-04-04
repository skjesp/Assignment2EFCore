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
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public List<Course> Courses { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public List<Assignment> Assignments { get; set; }

        public List<CourseStudent> CourseStudents { get; set; }
        
        public List<Group> Groups { get; set; }

        public List<GroupAssignment> GroupAssignments { get; set; }

        public List<StudentGroup> StudentGroup { get; set; }

        public async Task OnGetAsync()
        {
            //Load list of Courses
            Courses = await _db.Courses.AsNoTracking().ToListAsync();

            //Load list of Teachers
            Teachers = await _db.Teachers.AsNoTracking().ToListAsync();

            //Load list of Students
            Students = await _db.Students.AsNoTracking().ToListAsync();

            //Load list of Assignments
            Assignments = await _db.Assignments.AsNoTracking().ToListAsync();
            
            //Load list of CourseStudents
            CourseStudents = await _db.CourseStudents.AsNoTracking().ToListAsync();

            //Load list of Groups
            Groups = await _db.Groups.AsNoTracking().ToListAsync();

            //Load list of GroupAssignment
            GroupAssignments = await _db.GroupAssignments.AsNoTracking().ToListAsync();
        }


        //Search students by AU-id and get Courses with status and grade.
        public async Task<IActionResult> OnPostSearchStudentAsync(int studentId)
        {
            var studentcourse = from sc in _db.CourseStudents
                select sc;
        
            if (Convert.ToString(studentId) != String.Empty)
            {
                studentcourse = studentcourse.Where(s => s.StudentID.Equals(studentId));

                //Check if we found anyting
                if (studentcourse.AsNoTracking().ToList().Count != 0)
                {
                    //Succes found a match

                } else {

                    //Failed no match
                    return RedirectToPage();
                }

            } else {

                //Do nothing if no search id id entered.
                
            }

                //Update tables
                CourseStudents = await studentcourse.AsNoTracking().ToListAsync();

                //Load list of Courses
                Courses = await _db.Courses.AsNoTracking().ToListAsync();

                //Load list of Teachers
                Teachers = await _db.Teachers.AsNoTracking().ToListAsync();

                //Load list of Students
                Students = await _db.Students.AsNoTracking().ToListAsync();

                //Load list of Assignments
                Assignments = await _db.Assignments.AsNoTracking().ToListAsync();

                //Load list of Groups
                Groups = await _db.Groups.AsNoTracking().ToListAsync();

                //Load list of GroupAssignment
                GroupAssignments = await _db.GroupAssignments.AsNoTracking().ToListAsync();       

            return Page();
            //Update current page.
        }
    }
}

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

<<<<<<< HEAD
        public List<Assignment> Assignments { get; set; }

        public List<CourseStudent> CourseStudents { get; set; }
        
        public List<Group> Groups { get; set; }

        public List<GroupAssignment> GroupAssignments { get; set; }

=======
>>>>>>> parent of bdd8bf6... Feature/add-assignment completed
        public async Task OnGetAsync()
        {
            //Load list of Courses
            Courses = await _db.Courses.AsNoTracking().ToListAsync();

            //Load list of Teachers
            Teachers = await _db.Teachers.AsNoTracking().ToListAsync();

            //Load list of Students
            Students = await _db.Students.AsNoTracking().ToListAsync();
<<<<<<< HEAD

            //Load list of Assignments
            Assignments = await _db.Assignments.AsNoTracking().ToListAsync();
            
            //Load list of CourseStudents
            CourseStudents = await _db.CourseStudents.AsNoTracking().ToListAsync();

            //Load list of Groups
            Groups = await _db.Groups.AsNoTracking().ToListAsync();

            //Load list of GroupAssignment
            GroupAssignments = await _db.GroupAssignments.AsNoTracking().ToListAsync();
=======
>>>>>>> parent of bdd8bf6... Feature/add-assignment completed
        }

        public async Task OnPostAsync()
        {
            //Update current page.
        }
    }
}

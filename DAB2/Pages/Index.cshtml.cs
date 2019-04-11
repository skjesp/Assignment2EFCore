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

        public List<StudentGroup> StudentGroups { get; set; }

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
            CourseStudents = await _db.CourseStudents.AsNoTracking().Include(cs=>cs.Student).Include(cs=>cs.Course).ToListAsync();

            //Load list of Groups
            Groups = await _db.Groups.AsNoTracking().ToListAsync();

            //Load list of GroupAssignments
            GroupAssignments = await _db.GroupAssignments.AsNoTracking().Include(ga=>ga.Group).Include(ga=>ga.Assignment).Include(ga=>ga.Teacher).ToListAsync();

            //Load list of StudentGroups
            StudentGroups = await _db.StudentGroups.AsNoTracking().Include(sg=>sg.Student).Include(sg=>sg.Group).ToListAsync();
        }
    }
}

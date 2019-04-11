using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DAB2.Database;


namespace DAB2.Pages
{
    public class StudentCourse_AssignmentGradeModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<StudentGroup> StudentGroups;
        public List<GroupAssignment> GroupAssignments;

        public StudentCourse_AssignmentGradeModel(AppDbContext db)
        {
            _db = db;
            StudentGroups = new List<StudentGroup>();
            GroupAssignments = new List<GroupAssignment>();
        }
        public void OnGet()
        {

        }


    }
}
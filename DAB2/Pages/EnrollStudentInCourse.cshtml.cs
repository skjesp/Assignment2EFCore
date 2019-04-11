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
    public class EnrollStudentInCourseModel : PageModel
    {
        private readonly AppDbContext _db;

        public EnrollStudentInCourseModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int courseId { get; set; }

            public int studentId { get; set; }

            public bool isCoursePassed { get; set; }

            public bool isCourseActive { get; set; }
        }

        public List<SelectListItem> listStudents { get; set; }

        public List<SelectListItem> listCourses { get; set; }

        public void OnGet()
        {
            List<SelectListItem> listStudent = new List<SelectListItem>();   
            foreach (var student in _db.Students)
            {
                listStudent.Add(new SelectListItem() { Value = student.Id.ToString(), Text = student.AuId });
            }
            listStudents = listStudent;

            List<SelectListItem> listCourse = new List<SelectListItem>();  
            foreach (var course in _db.Courses)
            {
                listCourse.Add(new SelectListItem() { Value = course.Id.ToString(), Text = course.Name });
            }
            listCourses = listCourse;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var student = _db.Students.Single(s => s.Id.Equals(Input.studentId));

            var course = _db.Courses.Single(g => g.Id.Equals(Input.courseId));

            //Add object of CourseStudent to database & save changes.
            _db.Add(new CourseStudent{
                CourseID = Input.courseId,
                Course = course,
                StudentID = Input.studentId,
                Student = student,
                IsCourseActive = Input.isCourseActive,
                IsCoursePassed = Input.isCoursePassed,
                Grade = null
            });

            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
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
    public class AssignTeacherToCourseModel : PageModel
    {
        private readonly AppDbContext _db;

        public AssignTeacherToCourseModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int courseId { get; set; }

            public int teacherId { get; set; }

            public bool isAssistant { get; set; }
        }

        public List<SelectListItem> listTeachers { get; set; }

        public List<SelectListItem> listCourses { get; set; }

        public void OnGet()
        {
            List<SelectListItem> listTeacher = new List<SelectListItem>();   
            foreach (var teacher in _db.Teachers)
            {
                listTeacher.Add(new SelectListItem() { Value = teacher.Id.ToString(), Text = teacher.AuId });
            }
            listTeachers = listTeacher;

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

            var teacher = _db.Teachers.Single(s => s.Id.Equals(Input.teacherId));

            var course = _db.Courses.Single(g => g.Id.Equals(Input.courseId));

            //Add object of CourseStudent to database & save changes.
            _db.Add(new CourseTeacher{
                CourseId = Input.courseId,
                Course = course,
                TeacherId = Input.teacherId,
                Teacher = teacher,
                IsAssistant = Input.isAssistant
            });

            await _db.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
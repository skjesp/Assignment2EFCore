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
    public class GradeStudentModel : PageModel
    {
        private readonly AppDbContext _db;
        public GradeStudentModel(AppDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public CourseStudent courseStudent { get; set; }

        public List<SelectListItem> listGrade { get; set; }
        public List<SelectListItem> listStudent { get; set; }
        public List<SelectListItem> listCourse { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public int studentId { get; set; }

            public string grade { get; set; }
            public string course { get; set; }

        }
        //public void OnGet()
        //{
        //    List<SelectListItem> liststudents = new List<SelectListItem>();
        //    foreach (var student in _db.Students)
        //    {
        //        liststudents.Add(new SelectListItem() { Value = student.Id.ToString(), Text = student.Name.ToString() });
        //    }
        //    listStudent = liststudents;

        //    List<SelectListItem> listcourses = new List<SelectListItem>();
        //    foreach (var course in _db.Courses)
        //    {
        //        listcourses.Add(new SelectListItem() { Value = course.Id.ToString(), Text = course.Name.ToString() });
        //    }
        //    listCourse = listcourses;

        //    List<SelectListItem> listGrades = new List<SelectListItem>();
        //    listGrade.Add(new SelectListItem() { Value = "-3", Text = "-3" });
        //    listGrade.Add(new SelectListItem() { Value = "00", Text = "00" });
        //    listGrade.Add(new SelectListItem() { Value = "02", Text = "02" });
        //    listGrade.Add(new SelectListItem() { Value = "4", Text = "4" });
        //    listGrade.Add(new SelectListItem() { Value = "7", Text = "7" });
        //    listGrade.Add(new SelectListItem() { Value = "10", Text = "10" });
        //    listGrade.Add(new SelectListItem() { Value = "12", Text = "12" });

        //    listGrade = listGrades;
        //}
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    //Validedata ModelState is valid.
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    var student = _db.Students.Single(g => g.Id.Equals(Input.studentId));

        //    var course = _db.Courses.Single(a => a.Id.Equals(Input.course));



        //    //Add object to database & save changes.
        //    _db.CourseStudents.Add(new CourseStudent
        //    {
        //        StudentID = Input.studentId,
        //        CourseID = Input.course,
        //        CourseName = course.Name,
        //        StudentAuId = student.Name,
        //        Grade = Input.grade,
        //    });
        //    await _db.SaveChangesAsync();

        //    //Redirect to /Index page.
        //    return RedirectToPage("/Index");
        //}
    }
}
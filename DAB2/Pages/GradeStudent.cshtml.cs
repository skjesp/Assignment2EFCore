﻿using System;
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

        public CourseStudent courseStudent { get; set; }

        public List<SelectListItem> listGrade { get; set; }
        public List<SelectListItem> listStudent { get; set; }
        public List<SelectListItem> listCourse { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public int studentId { get; set; }

            public int grade { get; set; }

            public int courseId { get; set; }

        }
        public void OnGet()
        {
            List<SelectListItem> liststudents = new List<SelectListItem>();
            foreach (var student in _db.Students)
            {
                liststudents.Add(new SelectListItem() { Value = student.Id.ToString(), Text = student.AuId.ToString() });
            }
            listStudent = liststudents;

            List<SelectListItem> listcourses = new List<SelectListItem>();
            foreach (var course in _db.Courses)
            {
                listcourses.Add(new SelectListItem() { Value = course.Id.ToString(), Text = course.Name.ToString() });
            }
            listCourse = listcourses;

            List<SelectListItem> listGrades = new List<SelectListItem>();
            listGrades.Add(new SelectListItem() { Value = "-3", Text = "-3" });
            listGrades.Add(new SelectListItem() { Value = "00", Text = "00" });
            listGrades.Add(new SelectListItem() { Value = "02", Text = "02" });
            listGrades.Add(new SelectListItem() { Value = "4", Text = "4" });
            listGrades.Add(new SelectListItem() { Value = "7", Text = "7" });
            listGrades.Add(new SelectListItem() { Value = "10", Text = "10" });
            listGrades.Add(new SelectListItem() { Value = "12", Text = "12" });

            listGrade = listGrades;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            //Validedata ModelState is valid.
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //var currentStudent = await _db.CourseStudents.SingleAsync(s => s.Equals(Input.studentId) && s.Equals(Input.courseId));

            //currentStudent.Grade = Input.grade;
            var currentStudent = _db.CourseStudents.Single(a => a.StudentID.Equals(Input.studentId) && a.CourseID.Equals(Input.courseId));

            //Add object to database & save changes.
            //_db.CourseStudents.Add(new CourseStudent
            //{
            //    StudentID = Input.studentId,
            //    CourseID = Input.courseId,
            //    CourseName = course.Name,
            //    StudentAuId = student.Name,
            //    Grade = Input.grade,
            //});

            currentStudent.Grade = Input.grade;
            
            //Student not passed if grade == -3 or 00.
            if(Input.grade == -3 || Input.grade == 00)
            {
                currentStudent.IsCourseActive = true;
                currentStudent.IsCoursePassed = false;
            } else {
                currentStudent.IsCourseActive = false;
                currentStudent.IsCoursePassed = true;
            }

            _db.Attach(currentStudent).State = EntityState.Modified;

            //Check for state-changes (some or all values) and attached new values.
            //_db.Attach(currentStudent).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}
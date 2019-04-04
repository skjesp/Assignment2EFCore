﻿using System;
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
        public CourseStudent CourseStudent { get; set; }

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

            //Add object of Student to database & save changes.
            _db.Add(CourseStudent);
            await _db.SaveChangesAsync();
                
            //Redirect to /Index page.
            return RedirectToPage("/Index");
        }
    }
}
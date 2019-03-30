﻿using System;
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

        public async Task OnGetAsync()
        {
            //Load list of Courses
            Courses = await _db.Courses.AsNoTracking().ToListAsync();

            //Load list of Teachers
            Teachers = await _db.Teachers.AsNoTracking().ToListAsync();

            //Load list of Students
            Students = await _db.Students.AsNoTracking().ToListAsync();
        }

        public async Task OnPostAsync()
        {
            //Update current page.
        }
    }
}

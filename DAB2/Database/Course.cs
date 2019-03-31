using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; } 
        
        [Required]
        public string Name { get; set; }

        public string ContentId { get; set; }

        public string CalendarId { get; set; }

        public List<CourseTeacher> CourseTeacher { get; set; }

        public List<CourseAssignment> CourseAssignment { get; set; }
    }
}
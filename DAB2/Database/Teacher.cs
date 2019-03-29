using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; } 

        [Required]
        public string Birthday { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CourseTeacher> CourseTeacher { get; set; }
    }
}
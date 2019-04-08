using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Course
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public int CourseNr { get; set; }
        
        [Required]
        public string Name { get; set; }

        public List<CourseTeacher> CourseTeacher { get; set; }

        public List<CourseAssignment> CourseAssignment { get; set; }
        
        public List<CourseStudent> CourseStudents { get; set; }

        //One to One Course and Context
        public Content Content { get; set; }

    }
}
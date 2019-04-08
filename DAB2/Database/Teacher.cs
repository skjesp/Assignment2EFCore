using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string AuId { get; set; }

        [Required]
        public string Birthday { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CourseTeacher> CourseTeacher { get; set; }

        public List<GroupAssignment> GroupAssignment { get; set; }
    }
}
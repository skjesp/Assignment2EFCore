using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } 
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string EnrolledData { get; set; }

        [Required]
        public string GraduationDate { get; set; }

        public int GroupId { get; set; }
    }
}
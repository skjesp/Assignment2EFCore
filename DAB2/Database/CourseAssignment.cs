using System;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class CourseAssignment
    {
        [Key]
        public int CourseAssignmentId { get; set; } 

        [Required]
        public int MaxStudents { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public string CourseId { get; set; }
    }
}
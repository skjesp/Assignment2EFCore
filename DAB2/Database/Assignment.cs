using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; } 

        [Required]
        public string Name { get; set; }

        [Required]
        public string DueDate { get; set; }

        [Required]
        public int GroupSize { get; set; }

        public List<CourseAssignment> CourseAssignment { get; set; }

        public List<GroupAssignment> GroupAssignment { get; set; }
    }
}
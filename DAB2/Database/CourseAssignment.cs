using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class CourseAssignment
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

        public bool Active { get; set; }
    }
}
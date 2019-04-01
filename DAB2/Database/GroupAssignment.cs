using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class GroupAssignment
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        
        public string Grade { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class GroupAssignment
    {
        //Many to Many
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        
        public string Grade { get; set; }

        public int GroupNr { get; set; }

        public string AssignmentName { get; set; }

        //One to Many
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public string TeacherName { get; set; }
    }
}
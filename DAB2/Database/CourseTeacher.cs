using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class CourseTeacher
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        
        public bool IsAssistant { get; set; }


        public string TeacherAuId { get; set; }

        public string CourseName { get; set; }
    }
}
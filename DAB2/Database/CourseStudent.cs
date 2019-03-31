using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB2.Database
{
    public class CourseStudent
    {
        public string AUID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public bool IsCoursePassed { get; set; }
        public bool IsCourseActive { get; set; }

    }
}

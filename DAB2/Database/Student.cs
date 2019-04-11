using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string AuId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string EnrolledDate { get; set; }

        [Required]
        public string GraduationDate { get; set; }

        public List<CourseStudent> CourseStudents { get; set; }

        public List<StudentGroup> StudentGroup { get; set; }

        public int GroupId { get; set; }

        public List<CourseStudent> CourseStudents { get; set; }
    }
}

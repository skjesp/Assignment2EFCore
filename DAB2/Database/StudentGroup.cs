using System;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class StudentGroup
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public string StudentName { get; set; }

        public int GroupNr { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Calendar
    {
        [Key]
        public int CalendarId { get; set; } 

        [Required]
        public string Date { get; set; }

        public int CourseId { get; set; }
    }
}
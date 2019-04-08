using System;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; } 
        
        [Required]
        public int BinaryData { get; set; }

        [Required]
        public string GroupSignupLink { get; set; }

        [Required]
        public string AudioLink { get; set; }

        [Required]
        public string VideoLink { get; set; }

        public string ContentAreaId { get; set; }

        //One to One Course and Context
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
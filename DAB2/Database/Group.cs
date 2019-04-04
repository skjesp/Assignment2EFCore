using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAB2.Database
{
    public class Group
    {
        [Key]
        public int Id { get; set ;}

        [Required]
        public int GroupNr { get; set ;}
        public List<StudentGroup> StudentGroup { get; set; }
        public List<GroupAssignment> GroupAssignment { get; set; }
    }
}
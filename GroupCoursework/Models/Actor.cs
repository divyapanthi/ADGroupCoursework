using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCoursework.Models
{
    public class Actor
    {
        [Key]
        public long ActorNumber { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
    }
}

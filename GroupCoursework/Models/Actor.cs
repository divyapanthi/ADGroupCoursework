using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCoursework.Models
{
    public class Actor
    {
        [Key]
        public int ActorNumber { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorSurname { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;


namespace GroupCoursework.Models
{
    public class DVDCategory
    {
        [Key]
        public long CategoryNumber { get; set; }
        public String CategoryDescription { get; set; }
        public String AgeRestricted { get; set; }


    }
}

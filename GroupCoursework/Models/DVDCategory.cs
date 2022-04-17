using System;
using System.ComponentModel.DataAnnotations;


namespace GroupCoursework.Models
{
    public class DVDCategory
    {
        [Key]
        public int CategoryNumber { get; set; }
        public string CategoryDescription { get; set; }
        public string AgeRestricted { get; set; }


    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace GroupCoursework.Models
{
    public class MembershipCategory
    {
        [Key]
        public long MembershipCategoryNumber { get; set; }
        public string MembershipCategoryDescription { get; set; }
        public int MembershipCategoryTotalLoans { get; set; }
    }
}

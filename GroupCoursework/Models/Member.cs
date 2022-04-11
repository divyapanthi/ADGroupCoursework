using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace GroupCoursework.Models
{
    public class Member
    {
        [Key]
        public long MemberNumber { get; set; }
        public long MembershipCategoryNumber { get; set; }
        public string MemberFristName { get; set; }
        public string MemberLastName { get; set; }
        public string MemberAddress { get; set; }
        public DateTime MemberDOB { get; set; }

        [ForeignKey("MembershipCategoryNumber")]
        public MembershipCategory MembershipCategory { get; set; }

    }
}

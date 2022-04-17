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
        public int MemberNumber { get; set; }
        [ForeignKey("MembershipCategoryNumber")]
        public MembershipCategory MembershipCategory { get; set; }
        public string MemeberLastName { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberAddress { get; set; }

        public DateTime MemberDOB { get; set; }
    }
}

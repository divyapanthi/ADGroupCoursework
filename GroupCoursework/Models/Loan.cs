using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCoursework.Models
{
    public class Loan
    {
        [Key]
        public long LoanNumber { get; set; }
        public long LoanTypeNumber { get; set; }
        public long CopyNumber { get; set; }
        public long MemberNumber { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }

        [ForeignKey("LoanTypeNumber")]
        public LoanType LoanType { get; set; }

        [ForeignKey("CopyNumber")]
        public DVDCopy DVDCopy { get; set; }

        [ForeignKey("MemberNumber")]
        public Member Member { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GroupCoursework.Models
{
    public class LoanType
    {
        [Key]
        public long LoanTypeNumber { get; set; }
        public string LoanType { get; set; }
        public string LoanDuration { get; set; }
    }
}

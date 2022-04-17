using System.ComponentModel.DataAnnotations;

namespace GroupCoursework.Models
{
    public class LoanType
    {
        [Key]
        public int LoanTypeNumber { get; set; }
        public string Loan_type { get; set; }

        public string LoanDuration { get; set; }
    }
}

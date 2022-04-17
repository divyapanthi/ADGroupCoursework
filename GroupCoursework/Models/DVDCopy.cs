using System.ComponentModel.DataAnnotations;

namespace GroupCoursework.Models
{
    public class DVDCopy
    {
        [Key]
        public int CopyNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("DVDNumber")]
        public DVDTitle DVDTitle { get; set; }

        public DateTime DatePurchased { get; set; }
    }
}

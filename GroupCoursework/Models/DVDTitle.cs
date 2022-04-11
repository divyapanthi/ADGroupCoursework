using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCoursework.Models

{
    public class DVDTitle
    {
        [Key]
        public int DVDNumber { get; set; }
        public string CategoryNumber { get; set; }

        public string StudioNumber { get; set; }

        public string ProducerNumber { get; set; }

    }
}

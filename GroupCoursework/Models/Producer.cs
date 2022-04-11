using System.ComponentModel.DataAnnotations;
namespace GroupCoursework.Models
{
    public class Producer
    {
        [Key]
        public long ProducerNumber { get; set; }
        public string ProducerName { get; set; }
    }
}

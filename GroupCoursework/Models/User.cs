using System.ComponentModel.DataAnnotations;

namespace GroupCoursework.Models
{
    public class User
    {
        [Key]
        public long UserNumber { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string UserPassword { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupCoursework.Models
{
    public class CastMember
    {
        [Key]
        public int CastMemberNumber { get; set; }
        public int DVDNumber { get; set; }

        [ForeignKey("DVDNumber")]
        public DVDTitle DVDTitle { get; set; }

        [ForeignKey("ActorNumber")]
        public Actor Actor { get; set; }
    }
}

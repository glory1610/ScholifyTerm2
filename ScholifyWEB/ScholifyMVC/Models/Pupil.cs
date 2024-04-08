using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class Pupil
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Class { get; set; }

        public virtual ICollection<ParentsPupil> ParentsPupil { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScholifyMVC.Models
{
    public class ParentsPupil
    {
        [Key]
        public int Id { get; set; }

        public int ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Parents Parent { get; set; }

        public int PupilId { get; set; }

        [ForeignKey("PupilId")]
        public virtual Pupil Pupil { get; set; }
    }
}

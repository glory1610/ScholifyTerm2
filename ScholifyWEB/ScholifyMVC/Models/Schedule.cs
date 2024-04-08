using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DayOfWeek { get; set; }

        [Required]
        public string LessonTime { get; set; }

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        [Required]
        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Class { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
    }
}

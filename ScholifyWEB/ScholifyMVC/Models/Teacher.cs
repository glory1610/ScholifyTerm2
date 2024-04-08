using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Classes> Classes { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; } 

        public virtual ICollection<DayBook> DayBooks { get; set; } 
    }
}

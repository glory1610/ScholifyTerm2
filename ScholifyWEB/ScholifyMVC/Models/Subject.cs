using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        public string SubjectName { get; set; }

        public virtual ICollection<DayBook> DayBooks { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}

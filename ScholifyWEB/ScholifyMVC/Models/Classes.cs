using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }

        public string ClassName { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }

        public virtual ICollection<Pupil> Pupils { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<DayBook> DayBooks { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class DayBook
    {
        [Key]
        public int Id { get; set; }

        public int PupilId { get; set; }

        [ForeignKey("PupilId")]
        public Pupil Pupil { get; set; }

        public int Grade { get; set; }

        public string Attendance { get; set; }
    }
}

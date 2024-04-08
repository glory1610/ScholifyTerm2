using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string Role { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Pupil Pupil { get; set; }

        public virtual Parents Parents { get; set; }
    }
}

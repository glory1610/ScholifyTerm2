using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScholifyMVC.Models
{
    public class Advertisement
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ClassId { get; set; }

        [ForeignKey("ClassId")]
        public Classes Class { get; set; }
    }
}

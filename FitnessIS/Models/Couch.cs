using System.ComponentModel.DataAnnotations;

namespace FitnessIS.Models
{
    public class Couch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Training> Trainings { get; set; }
    }
}

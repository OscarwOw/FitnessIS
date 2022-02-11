using System.ComponentModel.DataAnnotations;

namespace FitnessIS.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Training> Trainings { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace FitnessIS.Models
{
    public class UserTraining
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public User user { get; set; }
        public int TrainingId { get; set; }
        public Training training { get; set; }

    }
}

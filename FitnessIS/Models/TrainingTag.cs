namespace FitnessIS.Models
{
    public class TrainingTag
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public Tag tag { get; set; }
        public int TrainingId { get; set; }
        public Training training { get; set; }
    }
}

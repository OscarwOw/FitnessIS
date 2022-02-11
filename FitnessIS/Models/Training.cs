namespace FitnessIS.Models
{
    public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int Capacity { get; set; }
        public ICollection<UserTraining> users { get; set; }
        public ICollection<TrainingTag> tags { get; set; }

    }
}

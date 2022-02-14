using FitnessIS.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessIS.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Couch> couches { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<Training> trainings { get; set; }
        public DbSet<TrainingTag> TrainingTags { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserTraining> userTrainings { get; set; }
        
    }
}

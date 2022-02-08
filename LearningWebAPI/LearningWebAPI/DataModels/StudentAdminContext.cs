using Microsoft.EntityFrameworkCore;

namespace LearningAPI.DataModels
{
    public class StudentAdminContext :DbContext
    {
        public StudentAdminContext(DbContextOptions <StudentAdminContext> Options) : base(Options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}

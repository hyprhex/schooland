using Microsoft.EntityFrameworkCore;
using SchooLand.Data.Entities;

namespace SchooLand.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<DepartmetSubject> departmetSubjects { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }
    }
}

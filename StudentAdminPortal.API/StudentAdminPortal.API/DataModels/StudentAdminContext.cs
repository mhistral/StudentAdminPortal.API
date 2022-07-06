using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext : DbContext
    {
        // constructor
        public StudentAdminContext(DbContextOptions<StudentAdminContext> option) : base (option)
        {

        }

        // student table create inside SQL Server when migrations are run
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}

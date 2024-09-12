using Microsoft.EntityFrameworkCore;
namespace WebApplication7.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
    }


    // DbContext used to perform operations on database tables
    public class SchoolDbContext : DbContext
    {
        // This property refer the databse table 
        // Multiple tables required multiple properties
        public DbSet<Student> Students { get; set; }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
         : base(options)
        {

        }


    }
}
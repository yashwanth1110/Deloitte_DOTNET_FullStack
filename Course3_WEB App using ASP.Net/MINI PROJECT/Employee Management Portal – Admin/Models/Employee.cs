using Microsoft.EntityFrameworkCore;

namespace Employee_Management_Portal___Admin.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }
    }
    public class User
    {
        public int USerID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }  

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
         : base(options)
        {

        }
    }
}

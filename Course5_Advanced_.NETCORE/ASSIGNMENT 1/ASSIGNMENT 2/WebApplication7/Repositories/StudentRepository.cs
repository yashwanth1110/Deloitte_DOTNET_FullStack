using WebApplication7.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Repositories;
using Microsoft.Identity.Client;

namespace WebApplication7.Repositories
{
    public class StudentRepository : IStudentRepository 
    {
        public SchoolDbContext _context;
        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents() 
        { 
            List<Student> students = _context.Students.ToList();
            return students;
        }
        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public void AddStudent(Student studentObj)
        {
            _context.Students.Add(studentObj);
            _context.SaveChanges();
        }
        public void DeleteStudent(int id)
        {
            Student student = _context.Students.Find(id);

            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}

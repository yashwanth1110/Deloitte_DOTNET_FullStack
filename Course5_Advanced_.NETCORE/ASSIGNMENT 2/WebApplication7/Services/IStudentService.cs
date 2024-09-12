using WebApplication7.Models;

namespace WebApplication7.Services
{
    public interface IStudentService 
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student studentObj);
        void DeleteStudent(int id);
        void UpdateStudent(Student student);
    }
}

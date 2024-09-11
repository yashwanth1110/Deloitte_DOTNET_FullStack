using WebApplication7.Models;

namespace WebApplication7.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student studentObj);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}

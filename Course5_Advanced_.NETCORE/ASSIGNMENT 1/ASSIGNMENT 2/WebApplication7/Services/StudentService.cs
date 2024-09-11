using WebApplication7.Models;
using WebApplication7.Repositories;

namespace WebApplication7.Services
{
    public class StudentService : IStudentService
    {
        public IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }
        public Student GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
        }

        public void AddStudent(Student studentObj)
        {
            _repository.AddStudent(studentObj);
        }

        public void DeleteStudent(int id)
        {
            _repository.DeleteStudent(id);
        }
        public void UpdateStudent(Student studentObj)
        {
            _repository.UpdateStudent(studentObj);
        }
    }
    
}

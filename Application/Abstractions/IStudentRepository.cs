using Domain;

namespace Application;

public interface IStudentRepository
{
    Task<List<Student>> GetAll();
    Task<Student> FindStudentById(Guid id);
    Task<Student> Register(Student student);
    Task<Student> Update(Student student);
    Task<string> Delete(Guid id);
}

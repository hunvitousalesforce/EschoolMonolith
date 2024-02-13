using Domain;

namespace Application;

public interface IStudentRepository
{
    Task<List<Student>> GetAll();
    Task<Student> FindStudentById(Guid id, CancellationToken cancellationToken);
    Task<Student> Register(Student student, CancellationToken cancellationToken);
    Task<Student> Update(Student student, CancellationToken cancellationToken);
    Task<string> Delete(Guid id, CancellationToken cancellationToken);
}

using Domain;
using MediatR;

namespace Application;

public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, Student>
{
    private readonly IStudentRepository _studentRepository;
    public GetStudentByIdQueryHandler(IStudentRepository repository)
    {
        _studentRepository = repository;
    }
    public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        var student = await _studentRepository.FindStudentById(request.StudentId);
        return student;
    }
}

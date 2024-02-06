using Domain;
using MediatR;

namespace Application;

public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Student>
{
    private readonly IStudentRepository _studentRepository;
    public CreateStudentCommandHandler(IStudentRepository repository)
    {
        _studentRepository = repository;
    }
    public async Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        var student = new Student
        {
            Firstname = request.Firstname,
            Lastname = request.Lastname,
            Gender = request.Gender,
            Phone = request.Phone,
            DOB = request.DOB,
            Email = request.Email,
            HashedPassword = request.Password,
            Grade = request.Grade
        };

        var newStudent = await _studentRepository.Register(student);

        return newStudent;
    }
}

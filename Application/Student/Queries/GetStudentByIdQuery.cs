using Domain;
using MediatR;

namespace Application;

public class GetStudentByIdQuery : IRequest<Student>
{
    public GetStudentByIdQuery(Guid id)
    {
        StudentId = id;
    }
    public Guid StudentId { get; set; }
}

using Domain;
using MediatR;

namespace Application;

public class GetStudentByIdQuery : IRequest<Student>
{
    public Guid StudentId { get; set; }
}

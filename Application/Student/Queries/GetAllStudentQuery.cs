using Domain;
using MediatR;

namespace Application;

public class GetAllStudentQuery : IRequest<APIResponse<List<Student>>>
{

}

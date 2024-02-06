using Domain;
using MediatR;

namespace Application;

public class CreateStudentCommand : IRequest<Student>
{
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly DOB { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Grade Grade { get; set; }
    public Gender Gender { get; set; }
}

using Domain;
using MediatR;

namespace Application;

public class CreateStudentCommand : IRequest<Student>
{
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public DOB? DOB {get; set;}
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Grade Grade { get; set; }
    public Gender Gender { get; set; }
}

public class DOB
{
    public DOB(int day, int month, int year) 
    {
        Day = day;
        Month = month;
        Year = year;
    }
    public int Year {get; set;}
    public int Day {get; set;}
    public int Month {get; set;}
}

namespace Domain;

public class Student : IAggregateRoot
{
    public StudentId Id {get; private set;}
    public Grade Grade {get; set;}
}

public record StudentId(Guid Id);
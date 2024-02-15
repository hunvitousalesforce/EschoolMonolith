namespace Domain;

public class Teacher
{
    public TeacherId Id {get; set;}
    
}

public record TeacherId(Guid Id);

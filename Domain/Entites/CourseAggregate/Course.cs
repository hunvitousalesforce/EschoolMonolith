namespace Domain;

public class Course : IAggregateRoot
{
    public Course(string name, string? description, int credit)
    {
        Id = new CourseId(Guid.NewGuid());
        Name = name;
        Description = description;
        Credit = credit;
    }
    public CourseId Id {get; private set;}
    public string Name {get; private set;} = string.Empty;
    public int Credit {get; private set;}
    public string? Description {get; private set;}
    public DateTime? StartDate {get; private set;}
    public DateTime? EndDate {get; private set;}
    public List<Enrollment> Enrollments {get; private set;} = [];
}

public record CourseId(Guid Id);
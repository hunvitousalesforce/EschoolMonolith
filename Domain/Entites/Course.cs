namespace Domain;

public class Course
{
    public Guid Id {get; set;}
    public Guid SubjectId {get; set;}
    public string Name {get; set;} = string.Empty;
    public string? Description {get; set;}
    public DateTime CreatedDate {get; set;}
}

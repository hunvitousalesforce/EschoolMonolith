namespace Domain;

public class Subject
{
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string? Description {get; set;}
    public DateTime CreatedDate {get; set;}
    public int Credit {get; set;}
    public List<Course> Courses {get;set;} = [];

}

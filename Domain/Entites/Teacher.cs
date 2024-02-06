namespace Domain;

public class Teacher : AppUser
{
    public List<Grade> Grades {get; set;} = [];
}

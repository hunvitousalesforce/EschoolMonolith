namespace Domain;

public class Enrollment
{
    public EnrollmentId Id {get; private set;}
    public StudentId StudentId {get; private set;}
    public DateTime EnrollDate {get; private set;}
    public Enrollment(StudentId studentId, CourseId courseId)
    {
        Id = new EnrollmentId(Guid.NewGuid());
        StudentId = studentId;
        EnrollDate = DateTime.Now;
    }
}

public record EnrollmentId(Guid Id);
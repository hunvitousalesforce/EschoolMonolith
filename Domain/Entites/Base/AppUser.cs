namespace Domain;

public class AppUser
{
    public Guid Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly DOB { get; set; }
    public string Email { get; set; } = string.Empty;
    public string HashedPassword { get; set; } = string.Empty;
    public Gender Gender { get; set; }
}

using Application;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;
    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<string> Delete(Guid id, CancellationToken cancellationToken)
    {
        var student = _context.Students.Where(s => s.Id == id).FirstAsync();
        _context.Remove(student);
        await _context.SaveChangesAsync(cancellationToken);
        return id.ToString();
    }

    public async Task<Student> FindStudentById(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Students.Where(s => s.Id == id).SingleAsync();
    }

    public async Task<List<Student>> GetAll()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> Register(Student student, CancellationToken cancellationToken)
    {
        await _context.AddAsync(student);
        await _context.SaveChangesAsync(cancellationToken);
        return student;
    }

    public async Task<Student> Update(Student student, CancellationToken cancellationToken)
    {
        var stud = await _context.Students.Where(s => s.Id == student.Id).SingleAsync();

        stud.Firstname = student.Firstname;
        stud.Lastname = student.Lastname;
        stud.Gender = student.Gender;
        stud.Phone = student.Phone;
        stud.Grade = student.Grade;
        stud.Email = student.Email;
        stud.DOB = student.DOB;

        await _context.SaveChangesAsync();
        return stud;
    }
}

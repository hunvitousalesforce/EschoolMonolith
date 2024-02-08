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
    public Task<string> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Student> FindStudentById(Guid id)
    {
        Student? student = await _context.Students.Where(s => s.Id == id).FirstOrDefaultAsync();
        return student;
    }

    public async Task<List<Student>> GetAll()
    {
        var students = await _context.Students.ToListAsync();
        return students;
    }

    public async Task<Student> Register(Student student)
    {
        if (student == null)
            return null;
        await _context.AddAsync(student);
        await _context.SaveChangesAsync();
        return student;
    }

    public Task<Student> Update(Student student)
    {
        throw new NotImplementedException();
    }
}

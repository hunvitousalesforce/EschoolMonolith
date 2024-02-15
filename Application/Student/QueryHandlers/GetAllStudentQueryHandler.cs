using System.Globalization;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application;

public class GetAllStudentQueryHandler : IRequestHandler<GetAllStudentQuery, APIResponse<List<Student>>>
{
    private readonly IStudentRepository _studentRepository;
    
    public async Task<APIResponse<List<Student>>> Handle(GetAllStudentQuery request, CancellationToken token)
    {
        var students = await _studentRepository.GetAll();

        var response = new APIResponse<List<Student>>
        {
            Payload = students
        };

        if (students == null) {
            response.Status = Status.Error;
            response.Message = "student table has no record";
        }
        return response;
    }

    
}

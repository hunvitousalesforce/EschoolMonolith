using Application;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Infrastructure;

public static class StudentEnpoints
{
    public static IEndpointRouteBuilder MapStudentEnpoints(this IEndpointRouteBuilder student)
    {
        student.MapGet("/api/v1/student/all", async (ISender sender) => {
            var query = new GetAllStudentQuery();
            try {
                var result = await sender.Send(query);
            } catch (Exception ex)
            {
                throw ex;
            }
        });

        student.MapGet("/api/v1/student/{Id}", async (ISender sender, string Id) =>
        {
            var student = await sender.Send(new GetStudentByIdQuery(Guid.Parse(Id)));
            return student;
        });

        student.MapPost("/api/v1/student/", async (ISender sender,[FromBody] CreateStudentCommand command) => {
            var student = await sender.Send(command);
            return student;
        });

        return student;
    }
}

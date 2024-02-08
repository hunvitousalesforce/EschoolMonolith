using Application;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Infrastructure;

public static class StudentEnpoints
{
    public static IEndpointRouteBuilder MapStudentEnpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/students/{Id}", async (ISender sender, string Id) =>
        {
            var student = await sender.Send(new GetStudentByIdQuery(Guid.Parse(Id)));
            return student;
        });
        return app;
    }
}

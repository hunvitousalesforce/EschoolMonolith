using System.Net.NetworkInformation;
using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.Replication;

namespace Infrastructure;

public static class DefaultServices
{
    public static IServiceCollection AddDefaultService(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(option => {
            var connectionString = "Server=localhost;Port=5100;Database=EschoolMonolith;User Id=postgres;Password=1234;";
            option.UseNpgsql(connectionString);
        });
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Application.AssemblyReference.Assembly));
        services.AddScoped<IStudentRepository, StudentRepository>();
        return services;
    }
}

using System.Net.NetworkInformation;
using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.Replication;

namespace Infrastructure;

public static class DefaultServices
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>();
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(Ping).Assembly)
        );
        return services;
    }
}

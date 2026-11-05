using HotelManagement.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IDashboardService, DashboardService>();
        services.AddScoped<IRoomService, RoomService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IAccountAuthenticationService, AuthenticationService>();
        return services;
    }
}

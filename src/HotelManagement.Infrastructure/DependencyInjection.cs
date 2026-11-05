using HotelManagement.Application.Abstractions;
using HotelManagement.Infrastructure.Persistence;
using HotelManagement.Infrastructure.Security;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IHotelReadRepository, InMemoryHotelReadRepository>();
        services.AddSingleton<IUserAccountRepository, InMemoryUserAccountRepository>();
        services.AddSingleton<IPasswordHasher, Pbkdf2PasswordHasher>();
        return services;
    }
}

using HotelManagement.Domain.Entities;

namespace HotelManagement.Application.Abstractions;

public interface IUserAccountRepository
{
    UserAccount? FindByEmail(string normalizedEmail);
    bool Add(UserAccount account);
}

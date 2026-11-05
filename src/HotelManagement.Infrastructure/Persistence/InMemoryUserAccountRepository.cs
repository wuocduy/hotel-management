using System.Collections.Concurrent;
using HotelManagement.Application.Abstractions;
using HotelManagement.Domain.Entities;

namespace HotelManagement.Infrastructure.Persistence;

public sealed class InMemoryUserAccountRepository : IUserAccountRepository
{
    private readonly ConcurrentDictionary<string, UserAccount> _accounts = new(StringComparer.Ordinal);

    public UserAccount? FindByEmail(string normalizedEmail) =>
        _accounts.GetValueOrDefault(normalizedEmail);

    public bool Add(UserAccount account) => _accounts.TryAdd(account.Email, account);
}

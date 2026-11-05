namespace HotelManagement.Domain.Entities;

public sealed class UserAccount
{
    public Guid Id { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string PasswordHash { get; init; } = string.Empty;
    public DateTimeOffset CreatedAtUtc { get; init; }
}

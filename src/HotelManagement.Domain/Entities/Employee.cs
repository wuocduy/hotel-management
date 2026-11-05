namespace HotelManagement.Domain.Entities;

public sealed class Employee
{
    public Guid Id { get; init; }
    public string FullName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string JobTitle { get; init; } = string.Empty;
    public Guid RoleId { get; init; }
    public bool IsActive { get; init; }
}

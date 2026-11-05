namespace HotelManagement.Application.DTOs.Roles;

public sealed record RoleDto(
    Guid Id,
    string Name,
    string Description,
    IReadOnlyCollection<string> Permissions,
    int EmployeeCount);

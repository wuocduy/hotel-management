namespace HotelManagement.Application.DTOs.Roles;

public sealed record CreateRoleRequest(
    string Name,
    string Description,
    IReadOnlyCollection<string> Permissions);

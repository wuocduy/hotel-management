namespace HotelManagement.Application.DTOs.Roles;

public sealed record UpdateRoleRequest(
    string Name,
    string Description,
    IReadOnlyCollection<string> Permissions);

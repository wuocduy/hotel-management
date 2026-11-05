namespace HotelManagement.Application.DTOs.Employees;

public sealed record UpdateEmployeeRequest(
    string FullName,
    string Email,
    string JobTitle,
    Guid RoleId,
    bool IsActive);

namespace HotelManagement.Application.DTOs.Employees;

public sealed record EmployeeDto(
    Guid Id,
    string FullName,
    string Email,
    string JobTitle,
    Guid RoleId,
    string RoleName,
    bool IsActive);

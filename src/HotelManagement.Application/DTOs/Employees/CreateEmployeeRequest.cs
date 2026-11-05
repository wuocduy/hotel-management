namespace HotelManagement.Application.DTOs.Employees;

public sealed record CreateEmployeeRequest(
    string FullName,
    string Email,
    string JobTitle,
    Guid RoleId);

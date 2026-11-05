using HotelManagement.Application.Abstractions;
using HotelManagement.Application.DTOs.Employees;
using HotelManagement.Application.DTOs.Roles;
using HotelManagement.Application.DTOs.Rooms;
using HotelManagement.Application.ViewModels;
using HotelManagement.Domain.Entities;

namespace HotelManagement.Application.Services;

public interface IDashboardService
{
    DashboardViewModel GetOverview();
}

public interface IRoomService
{
    IReadOnlyCollection<RoomDto> Search(string? keyword, RoomStatus? status);
}

public interface IEmployeeService
{
    IReadOnlyCollection<EmployeeDto> GetAll();
}

public interface IRoleService
{
    IReadOnlyCollection<RoleDto> GetAll();
}

public sealed class DashboardService(IHotelReadRepository repository) : IDashboardService
{
    public DashboardViewModel GetOverview()
    {
        var rooms = repository.GetRooms();
        return new DashboardViewModel(
            rooms.Count,
            rooms.Count(room => room.Status == RoomStatus.Occupied),
            rooms.Count(room => room.Status == RoomStatus.Available),
            rooms.Count(room => room.Status is RoomStatus.Cleaning or RoomStatus.Maintenance),
            rooms.Take(5).Select(RoomMappings.ToDto).ToArray());
    }
}

public sealed class RoomService(IHotelReadRepository repository) : IRoomService
{
    public IReadOnlyCollection<RoomDto> Search(string? keyword, RoomStatus? status)
    {
        var rooms = repository.GetRooms().AsEnumerable();
        if (!string.IsNullOrWhiteSpace(keyword))
            rooms = rooms.Where(room => room.Number.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || room.Category.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        if (status.HasValue)
            rooms = rooms.Where(room => room.Status == status.Value);

        return rooms.OrderBy(room => room.Number).Select(RoomMappings.ToDto).ToArray();
    }
}

public sealed class EmployeeService(IHotelReadRepository repository) : IEmployeeService
{
    public IReadOnlyCollection<EmployeeDto> GetAll()
    {
        var roles = repository.GetRoles().ToDictionary(role => role.Id, role => role.Name);
        return repository.GetEmployees()
            .OrderBy(employee => employee.FullName)
            .Select(employee => new EmployeeDto(employee.Id, employee.FullName, employee.Email, employee.JobTitle,
                employee.RoleId, roles.GetValueOrDefault(employee.RoleId, "Chua phan quyen"), employee.IsActive))
            .ToArray();
    }
}

public sealed class RoleService(IHotelReadRepository repository) : IRoleService
{
    public IReadOnlyCollection<RoleDto> GetAll()
    {
        var employees = repository.GetEmployees();
        return repository.GetRoles()
            .OrderBy(role => role.Name)
            .Select(role => new RoleDto(role.Id, role.Name, role.Description, role.Permissions,
                employees.Count(employee => employee.RoleId == role.Id)))
            .ToArray();
    }
}

internal static class RoomMappings
{
    public static RoomDto ToDto(Room room) => new(
        room.Id, room.Number, room.Category, room.Status.ToString(), room.NightlyRate);
}

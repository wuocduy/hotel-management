using HotelManagement.Domain.Entities;

namespace HotelManagement.Application.Abstractions;

public interface IHotelReadRepository
{
    IReadOnlyCollection<Room> GetRooms();
    IReadOnlyCollection<Employee> GetEmployees();
    IReadOnlyCollection<Role> GetRoles();
}

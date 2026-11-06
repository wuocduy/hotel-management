using HotelManagement.Application.Abstractions;
using HotelManagement.Domain.Entities;

namespace HotelManagement.Infrastructure.Persistence;

// Temporary data source. Replace this class with an EF Core repository when SQL Server is connected.
public sealed class InMemoryHotelReadRepository : IHotelReadRepository
{
    private static readonly Guid ManagerRole = Guid.Parse("a24a268d-4e34-4ca5-a580-c0df4c10cd01");
    private static readonly Guid ReceptionRole = Guid.Parse("acd2e6fd-029d-4d71-a7d5-4a2670d4ef44");
    private static readonly Guid HousekeepingRole = Guid.Parse("ed31d01f-0a43-47c1-9d79-11338a13a635");

    private static readonly Role[] Roles =
    [
        new() { Id = ManagerRole, Name = "Quan ly", Description = "Dieu hanh va bao cao", Permissions = ["Phong", "Nhan vien", "Bao cao", "Phan quyen"] },
        new() { Id = ReceptionRole, Name = "Le tan", Description = "Dat phong va check-in", Permissions = ["Khach hang", "Phong", "Dat phong"] },
        new() { Id = HousekeepingRole, Name = "Buong phong", Description = "Cap nhat trang thai phong", Permissions = ["Phong"] }
    ];

    private static readonly Employee[] Employees =
    [
            ];

    private static readonly Room[] Rooms =
    [
        new() { Id = Guid.NewGuid(), Number = "101", Category = "Deluxe King", Status = RoomStatus.Occupied, NightlyRate = 1450000 },
        new() { Id = Guid.NewGuid(), Number = "102", Category = "Deluxe Twin", Status = RoomStatus.Available, NightlyRate = 1350000 },
        new() { Id = Guid.NewGuid(), Number = "201", Category = "Executive Suite", Status = RoomStatus.Cleaning, NightlyRate = 2400000 },
        new() { Id = Guid.NewGuid(), Number = "202", Category = "Deluxe King", Status = RoomStatus.Available, NightlyRate = 1450000 },
        new() { Id = Guid.NewGuid(), Number = "301", Category = "Presidential Suite", Status = RoomStatus.Maintenance, NightlyRate = 5200000 },
        new() { Id = Guid.NewGuid(), Number = "302", Category = "Deluxe Twin", Status = RoomStatus.Occupied, NightlyRate = 1350000 }
    ];

    public IReadOnlyCollection<Room> GetRooms() => Rooms;
    public IReadOnlyCollection<Employee> GetEmployees() => Employees;
    public IReadOnlyCollection<Role> GetRoles() => Roles;
}

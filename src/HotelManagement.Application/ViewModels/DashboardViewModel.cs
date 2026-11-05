using HotelManagement.Application.DTOs.Rooms;

namespace HotelManagement.Application.ViewModels;

public sealed record DashboardViewModel(
    int TotalRooms,
    int OccupiedRooms,
    int AvailableRooms,
    int NeedsAttention,
    IReadOnlyCollection<RoomDto> RecentRooms);

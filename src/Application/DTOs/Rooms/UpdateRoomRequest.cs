using HotelManagement.Domain.Entities;

namespace HotelManagement.Application.DTOs.Rooms;

public sealed record UpdateRoomRequest(
    string Category,
    RoomStatus Status,
    decimal NightlyRate);

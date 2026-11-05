namespace HotelManagement.Application.DTOs.Rooms;

public sealed record RoomDto(
    Guid Id,
    string Number,
    string Category,
    string Status,
    decimal NightlyRate);

namespace HotelManagement.Application.DTOs.Rooms;

public sealed record CreateRoomRequest(
    string Number,
    string Category,
    decimal NightlyRate);

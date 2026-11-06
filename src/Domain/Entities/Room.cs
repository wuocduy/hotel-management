namespace HotelManagement.Domain.Entities;

public sealed class Room
{
    public Guid Id { get; init; }
    public string Number { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public RoomStatus Status { get; init; }
    public decimal NightlyRate { get; init; }
}

public enum RoomStatus
{
    Available,
    Occupied,
    Cleaning,
    Maintenance
}

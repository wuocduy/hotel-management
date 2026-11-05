namespace HotelManagement.Application.DTOs.Authentication;

public sealed record AuthenticatedUserDto(Guid Id, string FullName, string Email);

namespace HotelManagement.Application.DTOs.Authentication;

public sealed record AuthenticationResult(AuthenticatedUserDto? User, string? Error)
{
    public bool Succeeded => User is not null;
}

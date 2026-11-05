using HotelManagement.Application.Abstractions;
using HotelManagement.Application.DTOs.Authentication;
using HotelManagement.Domain.Entities;

namespace HotelManagement.Application.Services;

public interface IAccountAuthenticationService
{
    AuthenticationResult Login(LoginRequest request);
    AuthenticationResult Register(RegisterRequest request);
}

public sealed class AuthenticationService(
    IUserAccountRepository userAccountRepository,
    IPasswordHasher passwordHasher) : IAccountAuthenticationService
{
    public AuthenticationResult Login(LoginRequest request)
    {
        var account = userAccountRepository.FindByEmail(NormalizeEmail(request.Email));
        if (account is null || !passwordHasher.Verify(request.Password, account.PasswordHash))
            return new AuthenticationResult(null, "Email hoặc mật khẩu chưa chính xác.");

        return new AuthenticationResult(ToDto(account), null);
    }

    public AuthenticationResult Register(RegisterRequest request)
    {
        var email = NormalizeEmail(request.Email);
        if (userAccountRepository.FindByEmail(email) is not null)
            return new AuthenticationResult(null, "Email này đã được đăng ký.");

        var account = new UserAccount
        {
            Id = Guid.NewGuid(),
            FullName = request.FullName.Trim(),
            Email = email,
            PasswordHash = passwordHasher.Hash(request.Password),
            CreatedAtUtc = DateTimeOffset.UtcNow
        };

        return userAccountRepository.Add(account)
            ? new AuthenticationResult(ToDto(account), null)
            : new AuthenticationResult(null, "Email này đã được đăng ký.");
    }

    private static string NormalizeEmail(string email) => email.Trim().ToUpperInvariant();

    private static AuthenticatedUserDto ToDto(UserAccount account) =>
        new(account.Id, account.FullName, account.Email);
}

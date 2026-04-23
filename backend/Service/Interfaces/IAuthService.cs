using SpendSplit.Service.DTOs.Auth;

namespace SpendSplit.Service.Interfaces;

public interface IAuthService
{
    Task<string> RegisterAsync(RegisterRequest request);
    Task<string> LoginAsync(LoginRequest request);
}

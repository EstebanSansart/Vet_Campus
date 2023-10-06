using API.Dtos.Custom;

namespace API.Services
{
    public interface IAuthService
    {
        Task<AuthResponse> ReturnToken(AuthRequest auth);
        Task<AuthResponse> ReturnRefreshToken(RefreshTokenRequest refreshTokenRequest, int UserId);
    }
}
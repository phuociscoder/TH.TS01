using TH.TS01.ViewModels;

namespace TH.TS01.Services
{
    public interface IUserServices
    {
        Task<bool> Register(UserRegisterRequest request);
        Task<UserLoginResponse> Login(UserLoginRequest request);

    }
}

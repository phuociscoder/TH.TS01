using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TH.TS01.Services;
using TH.TS01.ViewModels;

namespace TH.TS01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices=userServices;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        { 
            var result = await _userServices.Register(request);
            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginRequest request)
        { 
            var result  = await _userServices.Login(request);
            return Ok(result);
        }
    }
}

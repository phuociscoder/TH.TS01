using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TH.TS01.Models;
using TH.TS01.Services;
using TH.TS01.ViewModels;

namespace TH.TS01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSheetController : ControllerBase
    {
        private readonly ITimeSheetServices _services;

        public TimeSheetController(ITimeSheetServices services)
        {
            _services=services;
        }

        [HttpPost("CheckIn")]
        public async Task<IActionResult> CheckIn(CheckInRequest request) {
            
            
          var result = await _services.CheckIn(request);
            return Ok(result);
        }

        [HttpPost("CheckOut")]
        public async Task<IActionResult> CheckOut(CheckOutRequest request) { 
            var result = await _services.CheckOut(request);
            return Ok(result);
        }
    }
}

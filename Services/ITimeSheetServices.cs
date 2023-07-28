using TH.TS01.Models;
using TH.TS01.ViewModels;

namespace TH.TS01.Services
{
    public interface ITimeSheetServices
    {
        Task<bool> CheckIn(CheckInRequest request);
        Task<bool> CheckOut(CheckOutRequest request);
        Task<TimeSheet> GetTimeSheet(int userId);
    }
}

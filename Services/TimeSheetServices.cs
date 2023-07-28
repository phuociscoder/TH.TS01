using Microsoft.EntityFrameworkCore;
using TH.TS01.Models;
using TH.TS01.ViewModels;

namespace TH.TS01.Services
{
    public class TimeSheetServices : ITimeSheetServices
    {
        private readonly ThDbContext _context;
        public TimeSheetServices(ThDbContext context) {  _context = context; }
        public async Task<bool> CheckIn(CheckInRequest request)
        {
            TimeSheet ts = new TimeSheet() { 
            UserId = request.UserId,
            CheckIn = request.CheckIn,
            };
            _context.TimeSheets.Add(ts);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<bool> CheckOut(CheckOutRequest request)
        {

            var ts = await _context.TimeSheets.Where(x => x.UserId == request.UserId && x.CheckIn != null && x.CheckOut == null).FirstOrDefaultAsync();
            ts.CheckOut = request.CheckOut;
            _context.Entry(ts).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public Task<TimeSheet> GetTimeSheet(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using TH.TS01.Models;
using TH.TS01.ViewModels;

namespace TH.TS01.Services
{
    public class UserServices : IUserServices
    {
        private readonly ThDbContext _dbContext;

        public UserServices(ThDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserLoginResponse> Login(UserLoginRequest request)
        {
            var user= _dbContext.Users.Include(t => t.UserRoles).Where(t => t.UserName == request.UserName && t.Password == request.Password).FirstOrDefault();
            if (user == null) return new UserLoginResponse() { IsSuccess = false };

            var userRole = user.UserRoles.FirstOrDefault();

            var isWorking = _dbContext.TimeSheets.FirstOrDefault(t => t.UserId == user.Id && t.CheckOut == null);

            var role = _dbContext.Roles.Find(userRole.RoleId);

            var result  = new UserLoginResponse() { FullName = user.FullName, BasicSal = user.BasicSal, IsSuccess = true, RoleName = role.RoleName, IsWorking = isWorking != null };
            return result;
        }

        public async Task<bool> Register(UserRegisterRequest request)
        {
            User user = new User() { FullName = request.FullName, BasicSal = request.BasicSal, Password = request.Password, UserName = request.UserName };
            _dbContext.Users.Add(user);
           await _dbContext.SaveChangesAsync();

           int newId = _dbContext.Users.OrderBy(t => t.Id).Last().Id;

            UserRole userRole = new UserRole() {
             RoleId = request.RoleId,
             UserId = newId };

            _dbContext.UserRoles.Add(userRole);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        
    }
}

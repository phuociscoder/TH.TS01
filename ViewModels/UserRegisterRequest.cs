namespace TH.TS01.ViewModels
{
    public class UserRegisterRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public long BasicSal { get; set; }
    }
}

namespace TH.TS01.ViewModels
{
    public class UserLoginRequest
    {
        public string UserName { get; set;}
        public string Password { get; set;}
    }

    public class UserLoginResponse { 
        public bool IsSuccess { get; set;}
        public string FullName { get; set;}
        public string RoleName { get; set; }

        public long BasicSal { get; set; }

        public bool IsWorking { get; set; }
    }
}

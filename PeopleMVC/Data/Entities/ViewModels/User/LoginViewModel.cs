namespace PeopleMVC.Data.Entities.ViewModels.User
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public string ReturnUrl { get; set; }

        public bool RememberLogin { get; set; }

        public LoginViewModel()
        {

        }
        public LoginViewModel(string password, string username)
        {
            this.UserName = username;
            this.Password = password;
        }
    }
}
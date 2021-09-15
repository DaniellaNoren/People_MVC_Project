using Microsoft.AspNetCore.Identity;
using PeopleMVC.Data.DataManagement.User;
using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.User
{
    public class UserService : IUserService
    {
      
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        public UserService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        public UserModel Add(CreateUserViewModel person)
        {
            throw new NotImplementedException();
        }

        public UsersViewModel All()
        {
            throw new NotImplementedException();
        }

        public UserModel Edit(string id, CreateUserViewModel person)
        {
            throw new NotImplementedException();
        }

        public UserModel FindBy(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> Login(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        public  bool Login(LoginViewModel login)
        {

            ApplicationUser user = Login(login.UserName).Result;

            if(user != null)
            {
                var signInResult = _signInManager.PasswordSignInAsync(user, login.Password, true, false);
                return signInResult.Result.Succeeded;
            }

            return false;
        }

        public async void LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            LogoutAsync();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using PeopleMVC.Data.DataManagement.User;
using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.User
{
    public class UserService : IUserService
    {
      
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        public UserService(SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._roleManager = roleManager;
        }


        public UserViewModel Add(CreateUserViewModel user)
        {
            ApplicationUser createdUser = GetUserFromModel(user);

            IdentityResult result = _userManager.CreateAsync(createdUser, user.Password).Result;
            
            if (result.Succeeded)
            {
                if (!_roleManager.RoleExistsAsync("User").Result)
                {
                    _roleManager.CreateAsync(new IdentityRole("User"));
                }
                
                var res = _userManager.AddToRoleAsync(createdUser, "USER").Result;
                if (res.Succeeded)
                {

                }
                else
                {

                }
               
            }
            else
            {
                
            }
           

            return GetModelFromUser(createdUser);
        }

        private UserViewModel GetModelFromUser(ApplicationUser user)
        {
            UserViewModel model = new UserViewModel()
            {
                UserName = user.UserName,
                FullName = user.FirstName + " " + user.LastName,
                Email = user.Email,
                Birthday = user.Birthday
            };

            return model;
        }

        private ApplicationUser GetUserFromModel(CreateUserViewModel user)
        {
            ApplicationUser createdUser = new ApplicationUser()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Birthday = user.Birthday,
                UserName = user.UserName
            };

            return createdUser;

        }

        public UsersViewModel All()
        {
            throw new NotImplementedException();
        }

        public UserViewModel Edit(string id, CreateUserViewModel person)
        {
            throw new NotImplementedException();
        }

        public UserViewModel FindBy(string userName)
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


using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.User
{
    public interface IUserService
    { 
        UserViewModel Add(CreateUserViewModel person);

        UsersViewModel All();

        UserViewModel FindBy(string userName);

        UserViewModel Edit(string id, CreateUserViewModel person);

        bool Remove(int id);

        bool Login(LoginViewModel login);

        void Logout();
    }
}

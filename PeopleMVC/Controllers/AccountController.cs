using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels.User;
using PeopleMVC.Data.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            this._userService = userService;
        }
        
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = "/people/peopleindex")
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl});
        }

        [AllowAnonymous]
        public IActionResult Register(string returnUrl = "/people/peopleindex")
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel model)
        {

            var user = _userService.Login(model);

            if (user) {

                return LocalRedirect(model.ReturnUrl);
            }
            else
            {
                return Unauthorized();
            }

        }


        public IActionResult LogOut()
        {
            _userService.Logout();

            return Redirect("/people/peopleindex");
        }
    }
}

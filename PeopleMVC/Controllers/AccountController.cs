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
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(CreateUserViewModel user, string returnUrl = "/people/peopleindex")
        {
            _userService.Add(user);

            return Redirect(returnUrl);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginViewModel() { ReturnUrl = "/people/peopleindex" } );
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

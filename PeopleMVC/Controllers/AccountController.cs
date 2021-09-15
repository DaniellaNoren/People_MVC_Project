
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels.User;
using PeopleMVC.Data.Services.User;
using System;

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
        public IActionResult Register(CreateUserViewModel user)
        {
            _userService.Add(user);

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginViewModel() { ReturnUrl = "/people/peopleindex" });
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel model)
        {
            if (_userService.Login(model))
            {

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

            return RedirectToAction("Login");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UserIndex()
        {
            return View(_userService.All());
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult AddRole(string userName, string role)
        {
            _userService.AddRole(userName, role);

            return RedirectToAction("UserIndex");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}

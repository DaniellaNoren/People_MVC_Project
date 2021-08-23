using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class PeopleController : Controller
    {
        private static IPeopleService _peopleService;
        public IActionResult Index()
        {
            return View();
        }
    }
}

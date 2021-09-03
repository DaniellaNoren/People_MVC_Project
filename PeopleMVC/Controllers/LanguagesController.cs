using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Services.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class LanguagesController : Controller
    {
        private readonly ILanguageService _service;

        public LanguagesController(ILanguageService service)
        {
            this._service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

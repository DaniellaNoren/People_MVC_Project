using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Services.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICityService _service;

        public CitiesController(ICityService service)
        {
            this._service = service;
        }
        public IActionResult CitiesIndex()
        {
            return View(_service.All());
        }

        [HttpPost]
        public IActionResult CreateCity(CityViewModel city)
        {
            _service.Add(city);

            return RedirectToAction("CitiesIndex");
        }
    }
}

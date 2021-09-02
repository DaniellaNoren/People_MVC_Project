using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Services.Cities;
using PeopleMVC.Data.Services.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICityService _service;
        private readonly ICountryService _countryService;

        public CitiesController(ICityService service, ICountryService countryService)
        {
            this._service = service;
            this._countryService = countryService;
        }
        public IActionResult CitiesIndex()
        {
            ViewBag.Countries = new SelectList(_countryService.All().Countries, "Id", "Name");

            return View(_service.All());
        }

        [HttpPost]
        public IActionResult CreateCity(CreateCityViewModel city)
        {
            if (ModelState.IsValid)
            {
                _service.Add(city);
            }

            return RedirectToAction("CitiesIndex");
        }
    }
}

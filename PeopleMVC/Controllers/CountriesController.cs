using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Services.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountryService _service;

        public CountriesController(ICountryService service)
        {
            this._service = service;
        }
        public IActionResult CountriesIndex()
        {
            return View(_service.All());
        }

        [HttpPost]
        public IActionResult CreateCountry(CountryViewModel country)
        {
            _service.Add(country);
            return RedirectToAction("CountriesIndex");
        }
    }
}

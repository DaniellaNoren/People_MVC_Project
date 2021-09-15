using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Entities.ViewModels.Country;
using PeopleMVC.Data.Services.Countries;
using PeopleMVC.Models.DataManagement;
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

        [HttpGet("/countries/{id}")]
        public IActionResult GetCountry(int id)
        {
            try
            {
                CountryViewModel country =_service.FindBy(id);
                return PartialView("Country", country);
            }
            catch (EntityNotFoundException)
            {
                return RedirectToAction("CountriesIndex");
            }
        }

        [HttpPost]
        public IActionResult CreateCountry(CreateCountryViewModel country)
        {
            _service.Add(country);
            return RedirectToAction("CountriesIndex");
        }

        [HttpPost("/countries/del/{id}")]
        public IActionResult DeleteCountry(int id)
        {
            _service.Remove(id);
            return RedirectToAction("CountriesIndex");
        }
    }
}

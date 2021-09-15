using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Services.Cities;
using PeopleMVC.Data.Services.Countries;
using PeopleMVC.Models.DataManagement;
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

        [HttpGet("cities/{id}")]
        public IActionResult GetCity(int id)
        {
            try
            {
                CityViewModel city = _service.FindBy(id);
                return PartialView("City", city);
            }
            catch (EntityNotFoundException)
            {
                return RedirectToAction("CitiesIndex");
            }
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

        [HttpPost("cities/del/{id}")]
        public IActionResult DeleteCity(int id)
        {
            _service.Remove(id);
            return RedirectToAction("CitiesIndex");
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Services.Countries;
using PeopleMVC.Models.DataManagement;
using PeopleMVC.Models.Services;
using System;

namespace PeopleMVC.Controllers
{
    [AllowAnonymous]
    public class ReactController : Controller
    {
        private readonly IPeopleService _peopleService;
        private readonly ICountryService _countryService;

        public ReactController(IPeopleService peopleService, ICountryService countryService)
        {
            this._peopleService = peopleService;
            this._countryService = countryService;
        }

        [HttpGet("[controller]/people")]
        public ActionResult<PeopleViewModel> GetAllPeople()
        {
            return new OkObjectResult(_peopleService.All());
        }

        [HttpGet("[controller]/countries")]
        public ActionResult<CountriesViewModel> GetAllCountries()
        {
            return new OkObjectResult(_countryService.All());
        }

        [HttpGet("[controller]/people/{id}")]
        public ActionResult<PeopleViewModel> GetOne(int id)
        {
            try
            {
                return new OkObjectResult(_peopleService.FindBy(id));
            }catch(EntityNotFoundException)
            {
                return new NotFoundResult();
            }

        }

        [HttpPost("[controller]/people")]
        public ActionResult<PersonViewModel> AddPerson([FromBody]CreatePersonViewModel person)
        {

            if (ModelState.IsValid)
            {
                PersonViewModel createdPerson = _peopleService.Add(person);
                
                return new OkObjectResult(createdPerson);
            }

            return new BadRequestResult();

        }

        [HttpDelete("[controller]/people/{id}")]
        public IActionResult RemovePerson(int id)
        {
            if (_peopleService.Remove(id))
            {
                return new OkResult();
            }

            return new NotFoundResult();
        }
    }
}

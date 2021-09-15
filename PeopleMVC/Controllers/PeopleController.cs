using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Services.Cities;
using PeopleMVC.Models.Entities;
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
        private static ICityService _cityService;

        public PeopleController(IPeopleService peopleService, ICityService cityService)
        {
            _peopleService = peopleService;
            _cityService = cityService;
        }
        public IActionResult PeopleIndex()
        {
            ViewBag.Cities = new SelectList(_cityService.All().Cities, "Id", "Name");
            return View(_peopleService.All());
        }
        
        [HttpPost]
        public IActionResult AddPerson(CreatePersonViewModel person) 
        {
            if (ModelState.IsValid)
            {
                _peopleService.Add(person);
            }

            return RedirectToAction("PeopleIndex");
        }

        public IActionResult FilterPeople(PeopleViewModel searchTerms)
        {
            return View("PeopleIndex", _peopleService.FindBy(searchTerms)); 
        }

        public IActionResult RemovePerson(int id)
        {
            _peopleService.Remove(id);

            return RedirectToAction("PeopleIndex");
        }

        [HttpPost]
        public IActionResult SortPeople(SortingModel sortingModel)
        {
            return View("PeopleIndex", _peopleService.SortBy(sortingModel.FieldName, sortingModel.Alphabetical));
        }

        [HttpPost("people/UpdatePerson")]
        public IActionResult UpdatePerson(Person person)
        {
            person.Id = 1;

        
            _peopleService.Edit(1, person);

            return RedirectToAction("PeopleIndex");
        }

    }
}

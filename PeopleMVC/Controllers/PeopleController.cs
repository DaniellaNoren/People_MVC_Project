using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Entities.ViewModels.Person;
using PeopleMVC.Data.Services.Cities;
using PeopleMVC.Data.Services.Languages;
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
        private static ILanguageService _languageService { get; set; }

        public PeopleController(IPeopleService peopleService, ICityService cityService, ILanguageService languageService)
        {
            _peopleService = peopleService;
            _cityService = cityService;
            _languageService = languageService;
        }
        public IActionResult PeopleIndex()
        {
            ViewBag.Cities = new SelectList(_cityService.All().Cities, "Id", "Name");
            ViewBag.Languages = new SelectList(_languageService.All().Languages, "Id", "LanguageName");

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
            ViewBag.Cities = new SelectList(_cityService.All().Cities, "Id", "Name");
            ViewBag.Languages = new SelectList(_languageService.All().Languages, "Id", "LanguageName");

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
            ViewBag.Cities = new SelectList(_cityService.All().Cities, "Id", "Name");
            ViewBag.Languages = new SelectList(_languageService.All().Languages, "Id", "LanguageName");

            return View("PeopleIndex", _peopleService.SortBy(sortingModel.FieldName, sortingModel.Alphabetical));
        }

        [HttpPost("people/UpdatePerson")]
        public IActionResult UpdatePerson(EditPersonViewModel person)
        {
            _peopleService.Edit(person.Id, person);

            return RedirectToAction("PeopleIndex");
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels;
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

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        public IActionResult PeopleIndex()
        {
            return View(_peopleService.All());
        }
        
        [HttpPost]
        public IActionResult AddPerson(CreatePersonViewModel person) 
        {
            if (ModelState.IsValid)
            {
                _peopleService.Add(person);

                return RedirectToAction("PeopleIndex");
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
    }
}

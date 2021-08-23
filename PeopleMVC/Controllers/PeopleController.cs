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
        public IActionResult Index()
        {
            return View(_peopleService.All());
        }
        
        [HttpPost]
        public IActionResult AddPerson(CreatePersonViewModel person) 
        {
            _peopleService.Add(person);

            return RedirectToAction("Index");
        }

        [HttpDelete("/{id}")]
        public IActionResult RemovePerson(int id)
        {
            _peopleService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities.ViewModels.Language;
using PeopleMVC.Data.Services.Languages;
using PeopleMVC.Models.DataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Controllers
{
    public class LanguagesController : Controller
    {
        private readonly ILanguageService _service;

        public LanguagesController(ILanguageService service)
        {
            this._service = service;
        }
        public IActionResult LanguageIndex()
        {
            return View(_service.All());
        }

        public IActionResult CreateLanguage(CreateLanguageViewModel language)
        {
            _service.Add(language);
            return RedirectToAction("LanguageIndex");
        }

        public IActionResult RemoveLanguage(int id)
        {
            _service.Remove(id);
            return RedirectToAction("LanguageIndex");

        }

        public IActionResult FindLanguage(int id)
        {
            try
            {
                return PartialView("Language", _service.FindBy(id));
            }
            catch (EntityNotFoundException)
            {
                return RedirectToAction("LanguageIndex");
            }
        }
    }
}

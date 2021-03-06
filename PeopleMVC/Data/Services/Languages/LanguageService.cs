using PeopleMVC.Data.DataManagement.Languages;
using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels.Language;
using PeopleMVC.Models.DataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepo _repo;

        public LanguageService(ILanguageRepo repo)
        {
            this._repo = repo;
        }
        public LanguageViewModel Add(CreateLanguageViewModel language)
        {
            Language createdLanguage = new Language() { Name = language.LanguageName };
            return GetViewModel(_repo.Create(createdLanguage));

        }

        public LanguagesViewModel All()
        {
            return new LanguagesViewModel() { Languages = _repo.Read().Select(l => GetViewModel(l)).ToList() };
        }

        public LanguageViewModel Edit(int id, Language language)
        {
            language.Id = id;
            language = _repo.Update(language);
            return GetViewModel(language);
        }

        public LanguageViewModel FindBy(int id)
        {
            return GetViewModel(_repo.Read(id));
        }

        public bool Remove(int id)
        {
            return _repo.Delete(_repo.Read(id));
        }

        public LanguageViewModel GetViewModel(Language language)
        {
            return new LanguageViewModel { LanguageName = language.Name, Id = language.Id };
        }
    }
}

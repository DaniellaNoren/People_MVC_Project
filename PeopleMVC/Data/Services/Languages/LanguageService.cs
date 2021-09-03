using PeopleMVC.Data.DataManagement.Languages;
using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels.Language;
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
            throw new NotImplementedException();
        }

        public LanguagesViewModel All()
        {
            throw new NotImplementedException();
        }

        public LanguageViewModel Edit(int id, Language language)
        {
            throw new NotImplementedException();
        }

        public LanguageViewModel FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

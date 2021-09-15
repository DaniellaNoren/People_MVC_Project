using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.Languages
{
    public interface ILanguageService
    {
        LanguageViewModel Add(CreateLanguageViewModel language);

        LanguagesViewModel All();

        LanguageViewModel FindBy(int id);

        LanguageViewModel Edit(int id, Language language);

        bool Remove(int id);
    }
}

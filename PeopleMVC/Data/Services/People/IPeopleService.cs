using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Entities.ViewModels.Person;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.Services
{
    public interface IPeopleService
    {
        PersonViewModel Add(CreatePersonViewModel person);

        PeopleViewModel All();

        PeopleViewModel FindBy(PeopleViewModel search);

        PersonViewModel FindBy(int id);

        PersonViewModel Edit(int id, EditPersonViewModel person);

        bool Remove(int id);

        PeopleViewModel SortBy(string fieldName, bool alphabetical);
    }
}

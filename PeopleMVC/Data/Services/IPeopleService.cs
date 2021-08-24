using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.Services
{
    public interface IPeopleService
    {
        Person Add(CreatePersonViewModel person);

        PeopleViewModel All();

        PeopleViewModel FindBy(PeopleViewModel search);

        Person FindBy(int id);

        Person Edit(int id, Person person);

        bool Remove(int id);

        PeopleViewModel SortBy(string fieldName, bool alphabetical);
    }
}

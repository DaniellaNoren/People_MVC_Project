using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.Services
{
    public class PeopleService : IPeopleService
    {
        public Person Add(CreatePersonViewModel person)
        {
            throw new NotImplementedException();
        }

        public PeopleViewModel All()
        {
            throw new NotImplementedException();
        }

        public Person Edit(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            throw new NotImplementedException();
        }

        public Person FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

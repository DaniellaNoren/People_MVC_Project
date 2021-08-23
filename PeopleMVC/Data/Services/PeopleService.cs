using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Models.DataManagement;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.Services
{
    public class PeopleService : IPeopleService
    {
        private IPeopleRepo _repo;

        public PeopleService(IPeopleRepo repo)
        {
            _repo = repo;
        }

        public Person Add(CreatePersonViewModel person)
        {
            return _repo.Create(person.FirstName, person.LastName, person.City, person.PhoneNr);
        }

        public PeopleViewModel All()
        {
            return new PeopleViewModel() { people = _repo.Read() };
        }

        public Person Edit(int id, Person person)
        {
            person.Id = id;
            return _repo.Update(person);
        }

        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            return new PeopleViewModel() { people = All().people.FindAll(p =>
            {
                return p.GetType().GetProperty(search.FieldName)
                   .GetValue(p).ToString()
                   .StartsWith(search.SearchTerm);

            }).ToList() 
            };
        }
        
        public Person FindBy(int id)
        {
            return _repo.Read(id);
        }

        public bool Remove(int id)
        {
            return _repo.Delete(FindBy(id));
        }
    }
}

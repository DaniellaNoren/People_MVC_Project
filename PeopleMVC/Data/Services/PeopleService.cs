﻿using PeopleMVC.Data.Entities;
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

        public PersonViewModel Add(CreatePersonViewModel person)
        {
           Person createdPerson =_repo.Create(person.FirstName, person.LastName, new City() { Name = person.City.Name }, person.PhoneNr, person.SocialSecurityNr);
           return GetPersonViewModelFromPerson(createdPerson);
        }

        public PeopleViewModel All()
        {
            return new PeopleViewModel() { People = _repo.Read().Select(p => GetPersonViewModelFromPerson(p)).ToList() };
        }

        public PersonViewModel Edit(int id, Person person)
        {
            person.Id = id;
            person =_repo.Update(person);
            return GetPersonViewModelFromPerson(person);
        }

        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            List<PersonViewModel> people = All().People;

            if (!string.IsNullOrEmpty(search.SearchTerm))
            {
                StringComparison stringComparison = search.CaseSensitive ?
                    StringComparison.CurrentCulture :
                    StringComparison.CurrentCultureIgnoreCase;

                people = people.FindAll(p =>
                {
                    return p.GetType().GetProperty(search.FieldName)
                       .GetValue(p).ToString()
                       .Contains(search.SearchTerm, stringComparison);

                }).ToList();
            }

            search.People = people;

            return search;
        }

        public PersonViewModel FindBy(int id)
        {
            Person person = _repo.Read(id);

            return GetPersonViewModelFromPerson(person);
        }

        private PersonViewModel GetPersonViewModelFromPerson(Person person)
        {
            return new PersonViewModel()
            {
                City = new CityViewModel() { Name = person.City.Name, Country = new CountryViewModel() { Name = person.City.Country.Name } },
                FirstName = person.FirstName,
                LastName = person.LastName,
                Id = person.Id,
                PhoneNr = person.PhoneNr,
                SocialSecurityNr = person.SocialSecurityNr
            };
        }
    

        public bool Remove(int id)
        {
            try
            { 
                return _repo.Delete(_repo.Read(id));
            }
            catch (EntityNotFoundException)
            {
                return false;
            }
            
        }

        public PeopleViewModel SortBy(string fieldName, bool alphabetical)
        {
            List<PersonViewModel> people = All().People;

            if (!string.IsNullOrEmpty(fieldName))
            {
                if (alphabetical)
                {
                    people = people.OrderBy(p =>
                    {
                        return p.GetType().GetProperty(fieldName)
                           .GetValue(p);

                    }).ToList();
                }
                else
                {
                    people = people.OrderByDescending(p =>
                    {
                        return p.GetType().GetProperty(fieldName)
                           .GetValue(p);

                    }).ToList();
                }
            }
            return new PeopleViewModel() { People = people };

        }
    }
}

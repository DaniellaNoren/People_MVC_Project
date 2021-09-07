﻿using Microsoft.EntityFrameworkCore;
using PeopleMVC.Data.DataBase;
using PeopleMVC.Data.Entities;
using PeopleMVC.Models.DataManagement;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement
{
    public class DatabasePeopleRepo : IPeopleRepo
    {
        private readonly PeopleContext _context;

        public DatabasePeopleRepo(PeopleContext context)
        {
            _context = context;
        }

        public Person Create(string firstName, string lastName, int cityId, string phoneNr, string socialSecurityNr, List<Language> languages)
        {
            Person person = new Person(firstName, lastName,cityId, phoneNr, socialSecurityNr);

            foreach (Language language in languages)
            {
                person.AddLanguage(language);
            }

            _context.People.Add(person); 
            _context.SaveChanges();

            return Read(person.Id);
        }

        public bool Delete(Person person)
        {
            try
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return false;
            }
           
          
            return true;
        }

        public List<Person> Read()
        {
            return _context.People.Include(p => p.Languages).ThenInclude(lp => lp.Language).Include(p => p.City).ThenInclude(c => c.Country).ToList();
        }

        public Person Read(int id)
        {
            Person person = _context.People.Include(p => p.Languages).ThenInclude(lp => lp.Language).Include(p => p.City).ThenInclude(c => c.Country).FirstOrDefault(p => p.Id == id);

            if (person == null)
                throw new EntityNotFoundException("Person with id " + id + " not found");

            return person;
        }

        public Person Read(string socialSecurityNr)
        {
            Person person = _context.People.First(p => p.SocialSecurityNr.Equals(socialSecurityNr));

            if (person == null)
                throw new EntityNotFoundException("Person with SSN " + socialSecurityNr + " not found");

            return person;

        }

        public Person Update(Person person)
        {
            _context.Update(person);
            _context.SaveChanges();

            return Read(person.Id);
        }
    }
}

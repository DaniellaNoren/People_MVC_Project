using Microsoft.EntityFrameworkCore;
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

        public Person Create(string firstName, string lastName, City city, string phoneNr, string socialSecurityNr)
        {
            Person person = new Person(firstName, lastName, city, phoneNr, socialSecurityNr);
            person = _context.People.Add(person).Entity;
            _context.SaveChanges();
            return person;
        }

        public bool Delete(Person person)
        {
            try
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                return false;
            }
           
          
            return true;
        }

        public List<Person> Read()
        {
            return _context.People.Include(p => p.City).ThenInclude(c => c.Country).ToList();
        }

        public Person Read(int id)
        {
            Person person = _context.People.Find(id);

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
            _context.Attach(person);
            _context.SaveChanges();

            return Read(person.Id);
        }
    }
}

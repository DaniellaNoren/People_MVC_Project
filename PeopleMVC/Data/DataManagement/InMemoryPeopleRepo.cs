using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.DataManagement
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private static List<Person> people = new List<Person>();
        private static int idCounter;

        public Person Create(string firstName, string lastName, string city, string phoneNr)
        {
            Person person = new Person(firstName, lastName, city, phoneNr, ++idCounter);
            people.Add(person);
            return person;
        }

        public bool Delete(Person person)
        {
            return people.Remove(person);
        }

        public List<Person> Read()
        {
            return people;
        }

        public Person Read(int id)
        {
            Person person = people.Find(p => p.Id == id);
            
            if(person != null)
            {
                return person;
            }

            throw new Exception("Person with id " + id + " not found");
        }

        public Person Update(Person person)
        {
            Person p = Read(person.Id);

            if (person.FirstName != null)
                p.FirstName = person.FirstName;
            if (person.LastName != null)
                p.LastName = person.LastName;
            if (person.City != null)
                p.City = person.City;
            if (person.PhoneNr != null)
                p.PhoneNr = person.PhoneNr;

            return p;
        }
    }
}

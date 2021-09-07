using PeopleMVC.Data.Entities;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.DataManagement
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
      
        private static int idCounter;
        private static List<Person> people = new List<Person>()
        {
             new Person("Tina", "Zwanzig", 0, "031-5092-333", ++idCounter, "1111111111"),
            new Person("Olle", "Larsson", 0, "074-3232-356", ++idCounter, "222222222"),
            new Person("Karin", "Andersson", 0, "074-3244-444", ++idCounter, "3333333333"),
            new Person("Fatima", "Koh", 0, "071-1234-123", ++idCounter, "4444444444")
           
        };

        public Person Create(string firstName, string lastName, int cityId, string phoneNr, string socialSecurityNr, List<Language> languages)
        {
            Person person = new Person(firstName, lastName, cityId, phoneNr, ++idCounter, socialSecurityNr);
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

            throw new EntityNotFoundException("Person with id " + id + " not found");
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

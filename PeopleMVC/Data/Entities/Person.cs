using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.Entities
{
    public class Person
    {
        public string FirstName { get { return firstName; } set { firstName = value; } }
        private string firstName;
        public string LastName { get { return lastName; } set { lastName = value; } }
        private string lastName;
        public string City { get { return city; } set { city = value; } }
        private string city;
        public string PhoneNr { get { return phoneNr; } set { phoneNr = value; } }
        private string phoneNr;
        public int Id { get { return id; } set { id = value; } }
        private int id;
        public Person(string firstName, string lastName, 
            string city, string phoneNr, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.PhoneNr = phoneNr;
            this.Id = id;
        }
        public Person()
        {

        }
    }
}

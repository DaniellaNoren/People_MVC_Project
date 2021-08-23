using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class CreatePersonViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }

        public CreatePersonViewModel(string firstName, string lastName, string city, string phoneNr)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.PhoneNr = phoneNr;
        }

        public CreatePersonViewModel()
        {

        }
    }
}

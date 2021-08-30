using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public string City { get; set; }
        [Phone]
        public string PhoneNr { get; set; }

        [Required]
        [StringLength(10)]
        public string SocialSecurityNr { get; set; }

        public CreatePersonViewModel(string firstName, string lastName, string city, string phoneNr, string socialSecurityNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.PhoneNr = phoneNr;
            this.SocialSecurityNr = socialSecurityNumber;
        }

        public CreatePersonViewModel()
        {

        }
    }
}

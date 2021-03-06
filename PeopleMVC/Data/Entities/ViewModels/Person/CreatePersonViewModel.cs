using PeopleMVC.Data.Entities.ViewModels.Language;
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
        public int CityId { get; set; }

        [Phone]
        public string PhoneNr { get; set; }

        [Required]
        [StringLength(10)]
        public string SocialSecurityNr { get; set; }
        public List<int> LanguageIds { get; set; }
        public CreatePersonViewModel(string firstName, string lastName, int cityId, string phoneNr, string socialSecurityNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CityId = cityId;
            this.PhoneNr = phoneNr;
            this.SocialSecurityNr = socialSecurityNumber;
        }

        public CreatePersonViewModel()
        {

        }
    }
}

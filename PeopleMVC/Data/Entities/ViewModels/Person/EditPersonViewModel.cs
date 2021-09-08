using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels.Person
{
    public class EditPersonViewModel
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

        public List<int> LanguageIds { get; set; }

        public int Id { get; set; }

        public EditPersonViewModel()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class CreateCityViewModel
    {

        [Required]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public CreateCityViewModel()
        {

        }
    }
}

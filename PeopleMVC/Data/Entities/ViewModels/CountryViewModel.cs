using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class CountryViewModel
    {
        [Required]
        public string Name { get; set; }

        public CountryViewModel()
        {

        }
    }
}

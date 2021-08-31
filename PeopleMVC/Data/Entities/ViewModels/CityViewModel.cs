using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class CityViewModel
    {
        public string Name { get; set; }
        public CountryViewModel Country { get; set; }

        public CityViewModel()
        {

        }
    }
}

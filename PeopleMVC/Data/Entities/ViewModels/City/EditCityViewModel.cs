using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels.City
{
    public class EditCityViewModel
    {
     
        public string Name { get; set; }

        public int CountryId { get; set; }

        public int Id { get; set; }

        public EditCityViewModel()
        {

        }

    }
}

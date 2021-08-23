using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> people { get; set; }

        public string FieldName { get; set; }

        public string SearchTerm { get; set; }

        public PeopleViewModel()
        {

        }
    }
}

using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class PeopleViewModel
    {
        [Required]
        public List<Person> People { get; set; }

        [Required]
        public string FieldName { get; set; }

        [Required]
        public string SearchTerm { get; set; }

        public bool CaseSensitive { get; set; }

        public PeopleViewModel()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels
{
    public class SortingModel
    {
        [Required]
        public bool Alphabetical { get; set; }
        [Required]
        public string FieldName { get; set; }

        public SortingModel()
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels.Country
{
    public class CreateCountryViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public CreateCountryViewModel()
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities.ViewModels.User
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public UserViewModel()
        {

        }
    }
}

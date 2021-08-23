﻿using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Models.DataManagement
{
    public interface IPeopleRepo
    {
        Person Create(string firstName, string lastName, string city, string phoneNr);

        List<Person> Read();

        Person Read(int id);

        Person Update(Person person);

        bool Delete(Person person);

    }
}
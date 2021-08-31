using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement.Countries
{
    public class DatabaseCountryRepo : ICountryRepo
    {
        public Country Create(string countryName)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Country country)
        {
            throw new NotImplementedException();
        }

        public List<Country> Read()
        {
            throw new NotImplementedException();
        }

        public Country Read(int id)
        {
            throw new NotImplementedException();
        }

        public Country Update(Country country)
        {
            throw new NotImplementedException();
        }
    }
}

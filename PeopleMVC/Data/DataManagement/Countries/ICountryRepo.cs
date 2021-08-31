using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement.Countries
{
    public interface ICountryRepo 
    {
        Country Create(string countryName);

        List<Country> Read();

        Country Read(int id);

        Country Update(Country country);

        bool Delete(Country country);
    }
}

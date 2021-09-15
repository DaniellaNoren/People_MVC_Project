using Microsoft.AspNetCore.Mvc;
using PeopleMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement.Cities
{
    public interface ICityRepo 
    {
        City Create(int countryId, string cityName);

        List<City> Read();

        City Read(int id);

        City Update(City city);

        bool Delete(City city);
    }
}

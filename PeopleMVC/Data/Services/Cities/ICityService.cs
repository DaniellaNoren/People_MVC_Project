using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.Cities
{
    public interface ICityService
    {
        CityViewModel Add(CityViewModel country);

        CitiesViewModel All();

        CityViewModel FindBy(int id);

        CityViewModel Edit(int id, City city);

        bool Remove(int id);
    }
}

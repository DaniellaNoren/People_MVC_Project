using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Data.Entities.ViewModels.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.Countries
{
    public interface ICountryService
    {
        CountryViewModel Add(CreateCountryViewModel country);

        CountriesViewModel All();

        CountryViewModel FindBy(int id);

        CountryViewModel Edit(int id, Country country);

        bool Remove(int id);
        
    }
}

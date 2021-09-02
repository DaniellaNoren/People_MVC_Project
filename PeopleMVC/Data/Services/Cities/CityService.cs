using PeopleMVC.Data.DataManagement.Cities;
using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Models.DataManagement;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.Cities
{
    public class CityService : ICityService
    {
        private readonly ICityRepo _repo;

        public CityService(ICityRepo repo)
        {
            this._repo = repo;
        }
        public CityViewModel Add(CityViewModel country)
        {
            City city = _repo.Create(country.Country.Id, country.Name);
            return GetViewModelFromEntity(city);
        }

        public CitiesViewModel All()
        {
            return new CitiesViewModel() { Cities = _repo.Read().Select(c => GetViewModelFromEntity(c)).ToList() };
        }

        public CityViewModel Edit(int id, City city)
        {
            city.Id = id;
            city = _repo.Update(city);
            return GetViewModelFromEntity(city);
        }

        public CityViewModel FindBy(int id)
        {
            return GetViewModelFromEntity(_repo.Read(id));
        }

        public bool Remove(int id)
        {

            return _repo.Delete(_repo.Read(id));

        }

        private CityViewModel GetViewModelFromEntity(City city)
        {
            return new CityViewModel() { Name = city.Name, Country = new CountryViewModel() { Name = city.Country.Name }, Id = city.Id };
        }
    }
}

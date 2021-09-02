﻿using PeopleMVC.Data.DataManagement.Countries;
using PeopleMVC.Data.Entities;
using PeopleMVC.Data.Entities.ViewModels;
using PeopleMVC.Models.DataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Services.Countries
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepo _repo;

        public CountryService(ICountryRepo repo)
        {
            this._repo = repo;
        }
        public CountryViewModel Add(CountryViewModel country)
        {
            Country createdCountry = _repo.Create(country.Name);
            return GetCountryViewModelFromEntity(createdCountry);
        }

        public CountriesViewModel All()
        {
            return new CountriesViewModel() { Countries = _repo.Read().Select(c => GetCountryViewModelFromEntity(c)).ToList() };
        }

        public CountryViewModel Edit(int id, Country country)
        {
            country.Id = id;
            country = _repo.Update(country);
            return GetCountryViewModelFromEntity(country);
        }

        public CountryViewModel FindBy(int id)
        {
            Country c = _repo.Read(id);
            return GetCountryViewModelFromEntity(c);
        }

        public bool Remove(int id)
        {
            return _repo.Delete(_repo.Read(id));
        }

        public CountryViewModel GetCountryViewModelFromEntity(Country country)
        {
            return new CountryViewModel() { Name = country.Name };
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleMVC.Data.DataBase;
using PeopleMVC.Data.Entities;
using PeopleMVC.Models.DataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement.Countries
{
    public class DatabaseCountryRepo : ICountryRepo
    {
        private readonly PeopleContext _context;

        public DatabaseCountryRepo(PeopleContext context)
        {
            this._context = context;
        }
        public Country Create(string countryName)
        {
            Country country =_context.Countries.Add(new Country() { Name = countryName }).Entity;
            _context.SaveChanges();
            return country;
        }

        public bool Delete(Country country)
        {
            try
            {
                _context.Countries.Remove(country);
                _context.SaveChanges();
            }catch(DbUpdateException)
            {
                return false;
            }
           
            return true;
        }

        public List<Country> Read()
        {
            return _context.Countries.Include(c => c.Cities).ToList();
        }

        public Country Read(int id)
        {
            Country country = _context.Countries.Find(id);

            if (country == null)
            {
                throw new EntityNotFoundException("Country with id " + id + " cannot be found");
            }

            return country;
        }

        public Country Update(Country country)
        {
            _context.Attach(country);
            _context.SaveChanges();

            return Read(country.Id);
        }
    }
}

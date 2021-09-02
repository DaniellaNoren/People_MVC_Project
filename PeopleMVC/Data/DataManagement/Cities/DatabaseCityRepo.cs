using Microsoft.EntityFrameworkCore;
using PeopleMVC.Data.DataBase;
using PeopleMVC.Data.Entities;
using PeopleMVC.Models.DataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement.Cities
{
    public class DatabaseCityRepo : ICityRepo
    {
        private readonly PeopleContext _context;

        public DatabaseCityRepo(PeopleContext context)
        {
            _context = context;
        }
        public City Create(int countryId, string cityName)
        {
            return _context.Cities.Add(new City() { CountryId = countryId, Name = cityName }).Entity;
        }

        public bool Delete(City city)
        {
            try
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return false;
            }
        

            return true;
        }

        public List<City> Read()
        {
            return _context.Cities.Include(c => c.Country).ToList(); 
        }

        public City Read(int id)
        {
            City city = _context.Cities.Find(id);

            if(city == null)
            {
                throw new EntityNotFoundException("City with id " + id + " cannot be found");
            }

            return city;

        }

        public City Update(City city)
        {
            _context.Attach(city);
            _context.SaveChanges();

            return Read(city.Id);
        }
    }
}

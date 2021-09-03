using Microsoft.EntityFrameworkCore;
using PeopleMVC.Data.Entities;
using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataBase
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Language> Languages { get; set; }
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasIndex(p => p.SocialSecurityNr).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            
            Country sweden = new Country() { Name = "Sweden", Id = 1 };
            Country germany = new Country() { Name = "Germany", Id = 2 };
            Country usa = new Country() { Name = "USA", Id = 3 };
            Country norway = new Country() { Name = "Norway", Id = 4 };

            City stockholm = new City() { Name = "Stockholm", Id = 1, CountryId = sweden.Id };
            City goteborg = new City() { Name = "Göteborg", Id = 2, CountryId = sweden.Id };
            City berlin = new City() { Name = "Berlin", Id = 3, CountryId = germany.Id };
            City frankfurt = new City() { Name = "Frankfurt", Id = 4, CountryId = germany.Id };
            City chicago = new City() { Name = "Chicago", Id = 5, CountryId = usa.Id };
            City houston = new City() { Name = "Houston", Id = 6, CountryId = usa.Id };
            City oslo = new City() { Name = "Oslo", Id = 7, CountryId = norway.Id };

            Person tina = new Person() { FirstName = "Tina", LastName = "Zwanzig", PhoneNr = "031-5092-333", CityId = berlin.Id, Id = 1, SocialSecurityNr = "9206901234" };
            Person olle = new Person() { FirstName = "Olle", LastName = "Larsson", PhoneNr = "074-3232-356", CityId = stockholm.Id, Id = 2, SocialSecurityNr = "9206902222" };
            Person karin = new Person() { FirstName = "Karin", LastName = "Andersson", PhoneNr = "074-3244-444", Id = 3, CityId = goteborg.Id, SocialSecurityNr = "9206901111" };
            Person fatima = new Person() { FirstName = "Fatima", LastName = "Koh", PhoneNr = "071-1234-123", Id = 4, CityId = goteborg.Id, SocialSecurityNr = "9206905678" };

            modelBuilder.Entity<Person>().HasData(tina, olle, karin, fatima);
            modelBuilder.Entity<City>().HasData(stockholm, goteborg, berlin, frankfurt, chicago, houston, oslo);
            modelBuilder.Entity<Country>().HasData(sweden, germany, usa, norway);

        }
    }
}

using Microsoft.EntityFrameworkCore;
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

        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
           .HasAlternateKey(p => p.SocialSecurityNr);

            modelBuilder.Entity<Person>()
                  .HasData(new Person("Tina", "Zwanzig", "Berlin", "031-5092-333", 1, "9206901234"),
            new Person("Olle", "Larsson", "Stockholm", "074-3232-356", 2, "9206902222"),
            new Person("Karin", "Andersson", "Stockholm", "074-3244-444", 3, "9206901111"),
            new Person("Fatima", "Koh", "Göteborg", "071-1234-123", 4, "9206905678"));
        }
    }
}

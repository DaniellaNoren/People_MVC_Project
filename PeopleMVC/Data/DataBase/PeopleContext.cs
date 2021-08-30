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
    }
}

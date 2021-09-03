using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities
{
    public class Language
    {
        private int id;
        [Key]
        public int Id { get { return id; } set { id = value; } }

        private string name;
        [Required]
        [MaxLength(50)]
        public string Name { get { return name; } set { name = value; } }

        private List<Person> people;
        public List<Person> People { get { return people; } set { people = value; } }

        public Language()
        {

        }
    }
}

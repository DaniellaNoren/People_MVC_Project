using PeopleMVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Entities
{
    public class LanguagePerson
    {

        public Language Language { get; set; }
        public int LanguageId { get; set; }
        public Person Person{ get; set; }
        public int PersonId { get; set; }

        public LanguagePerson()
        {

        }
    }
}

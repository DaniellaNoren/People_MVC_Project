using PeopleMVC.Data.DataBase;
using PeopleMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.DataManagement.Languages
{
    public class DatabaseLanguageRepo : ILanguageRepo
    {
        private readonly PeopleContext _context;

        public DatabaseLanguageRepo(PeopleContext context)
        {
            this._context = context;
        }

        public Language Create(string languageName)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Language language)
        {
            throw new NotImplementedException();
        }

        public List<Language> Read()
        {
            return _context.Languages.ToList();
        }

        public Language Read(int id)
        {
            throw new NotImplementedException();
        }

        public Language Update(Language language)
        {
            throw new NotImplementedException();
        }
    }
}

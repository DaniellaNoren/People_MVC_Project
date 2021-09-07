using Microsoft.EntityFrameworkCore;
using PeopleMVC.Data.DataBase;
using PeopleMVC.Data.Entities;
using PeopleMVC.Models.DataManagement;
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

        public Language Create(Language language)
        {
            _context.Add(language);
            _context.SaveChanges();

            return Read(language.Id);
        }

        public bool Delete(Language language)
        {
            try
            {
                _context.Languages.Remove(language);
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return false;
            }

            return true;
        }

        public List<Language> Read()
        {
            return _context.Languages.ToList();
        }

        public Language Read(int id)
        {
            Language language = _context.Languages.Include(l => l.People).FirstOrDefault(l => l.Id == id);

            if (language != null)
                return language;

            throw new EntityNotFoundException("Language with id " + id + " not found.");


        }

        public Language Update(Language language)
        {
            _context.Update(language);
            _context.SaveChanges();

            return Read(language.Id);
        }
    }
}

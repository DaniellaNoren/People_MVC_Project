﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeopleMVC.Data.Entities;

namespace PeopleMVC.Data.DataManagement.Languages
{
    public interface ILanguageRepo
    {
        Language Create(Language language);

        List<Language> Read();

        Language Read(int id);

        Language Update(Language language);

        bool Delete(Language language);
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using Dal.models;
using Dal;
using Dal.pgDB;

namespace Bll
{
    public class LanguageMgr : ILanguageMgr
    {
        private readonly IRepository<Language> _repository;
        public LanguageMgr()
        {
            // Bad practice called "tight coupling"
            _repository = new PgRepository<Language>();
        }
        public void Add(Language language)
        {
            _repository.Add(language);
        }

        public void Edit(Language language)
        {
            Language existingLanguage = _repository.Find().First(p=>p.Id==language.Id);
            existingLanguage.Name=language.Name;
            existingLanguage.LastModificationDate=DateTime.Now.ToUniversalTime();
            _repository.Update();
        }

        public List<Language> Find(Language language)
        {
            var q = _repository.Find();
            if (language.Id > 0)
            {
                return q.Where(p => p.Id == language.Id).ToList();
            }

            if (language.Name.Length > 0)
            {
                q = q.Where(p => p.Name.Contains(language.Name));
            }

            return q.ToList();
        }

        public void Remove(int id)
        {
            Language existingLanguage=_repository.Find().First(p=>p.Id==id);
            _repository.Delete(existingLanguage);
        }
    }
}
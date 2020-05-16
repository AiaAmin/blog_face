using System.Collections.Generic;
using Dal.models;

namespace Bll
{
    public interface ILanguageMgr
    {
        void Add(Language language);
        void Edit(Language language);
        void Remove(int id);
        List<Language> Find(Language language);
    }
}
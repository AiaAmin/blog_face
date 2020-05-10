using System.Collections.Generic;
using Dal.models;

namespace Bll
{
    public interface ICityMgr
    {
        void Add(City city);
        void Edit(City city);
        void Remove(int id);
        List<City> Find(City city);
    }
}
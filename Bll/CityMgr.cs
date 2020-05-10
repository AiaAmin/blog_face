using System;
using System.Collections.Generic;
using System.Linq;
using Dal;
using Dal.models;
using Dal.pgDB;

namespace Bll
{
    public class CityMgr : ICityMgr
    {
        private readonly IRepository<City> _repository;

        public CityMgr()
        {
            // Bad practice called "tight coupling"
            _repository = new PgRepository<City>();
        }

        public void Add(City city)
        {
            _repository.Add(city);
        }

        public void Edit(City city)
        {
            City existingCity = _repository.Find().First(p => p.Id == city.Id);
            existingCity.Name = city.Name;
            existingCity.LastModificationDate = DateTime.Now.ToUniversalTime();
            _repository.Update();
        }

        public void Remove(int id)
        {
            City existingCity = _repository.Find().First(p => p.Id == id);
            _repository.Delete(existingCity);
        }

        public List<City> Find(City city)
        {
            var q = _repository.Find();
            if (city.Id > 0)
            {
                return q.Where(p => p.Id == city.Id).ToList();
            }

            if (city.Name.Length > 0)
            {
                q = q.Where(p => p.Name.Contains(city.Name));
            }

            return q.ToList();
        }
    }
}
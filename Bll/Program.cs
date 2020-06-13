using System;
using System.Collections.Generic;
using Dal;
using Dal.models;
using Dal.pgDB;

namespace Bll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia!");
            IRepository<Language> langRepo = new PgRepository<Language>();
            IRepository<City> cityRepo = new PgRepository<City>();
            IRepository<Skill> SkillRepo = new PgRepository<Skill>();
            /****Using repo*****/
            // insert
           /* langRepo.Add(new Language() {Name = "Arabic"});
            langRepo.Add(new Language() {Name = "English"});
            langRepo.Add(new Language() {Name = "French"});
           // -----------------------------------------------------------------
           cityRepo.Add(new City() { Name="Cairo"});
            cityRepo.Add(new City() { Name = "Alex" });
            cityRepo.Add(new City() { Name = "Kafr Elsheikh" });
            cityRepo.Add(new City() { Name = "Aswan" });
            cityRepo.Add(new City() { Name = "Giza" });*/
            // ------------------------------------------
            SkillRepo.Add(new Skill() { Name = "LEADERSHIP" });
            SkillRepo.Add(new Skill() { Name = "Good Communication" });
            // find
            //langRepo.Find()

            /****Using bll*****/
            ILanguageMgr langMngr = new LanguageMgr();
            

            // add
            //langMngr.Add(new Language() {Name = "Italian"});

            // find
            List<Language> foundLangs = langMngr.Find(new Language() {Name = "i"});
            foreach (Language lang in foundLangs)
            {
                Console.WriteLine(lang.Name);
            }

            // Edit
            langMngr.Edit(new Language() {Id = 2, Name = "British"});
            
            // Remove
            langMngr.Remove(2);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Dal;
using Dal.models;
using Dal.pgDB;
namespace Bll {
    public class SkillMgr : ISkillMgr {
        private readonly IRepository<Skill> _repository;
        public SkillMgr () {
            // Bad practice called "tight coupling"
            _repository = new PgRepository<Skill> ();
        }

        public void Add (Skill skill) {
            _repository.Add (skill);
        }

        public void Edit (Skill skill) {
            Skill existingSkill = _repository.Find ().First (p => p.Id == skill.Id);
            existingSkill.Name = skill.Name;
            existingSkill.LastModificationDate = DateTime.Now.ToUniversalTime ();
            _repository.Update ();
        }

        public List<Skill> Find (Skill skill) {
            var q = _repository.Find ();
            if (skill.Id > 0) {
                return q.Where (p => p.Id == skill.Id).ToList ();
            }

            if (skill.Name.Length > 0) {
                q = q.Where (p => p.Name.Contains (skill.Name));
            }

            return q.ToList ();
        }

        public void Remove (int id) {

            Skill existingSkill = _repository.Find ().First (p => p.Id == id);
            _repository.Delete (existingSkill);
        }
    }
}
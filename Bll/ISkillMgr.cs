using System.Collections.Generic;
using Dal.models;
namespace Bll {
    public interface ISkillMgr {

        void Add (Skill skill);
        void Edit (Skill skill);
        void Remove (int id);
        List<Skill> Find (Skill skill);
    }
}
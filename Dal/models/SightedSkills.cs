using System.Collections.Generic;
namespace Dal.models
{
    public class SightedSkills
    {
        public int Id {get;set;}
        public List <Skill> Skills {get;set;}
        public List <Sighted> SightedPeople {get;set;}
    }
}
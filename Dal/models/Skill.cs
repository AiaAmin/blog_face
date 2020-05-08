using System;
namespace Dal.models {
    public class Skill : IEntity {
        public int Id {get;set;}
        public string Name {get;set;}
        public SightedSkills SightedSkills {get;set;}
        public int SightedSkillsId { get; set; }

        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }


    }
}
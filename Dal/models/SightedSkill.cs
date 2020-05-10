using System;

namespace Dal.models
{
    public class SightedSkill : IEntity
    {
        public int Id { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
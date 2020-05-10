namespace Dal.models
{
    public class SightedSkill
    {
        public int Id { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
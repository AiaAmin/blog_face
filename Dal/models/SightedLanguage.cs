namespace Dal.models
{
    public class SightedLanguage
    {
        public int Id { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public int SkillId { get; set; }
        public Language Language { get; set; }
    }
}
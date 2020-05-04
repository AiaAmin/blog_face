using System;
namespace Dal.models {
    public class Meeting : IEntity {
        public int id { get; set; }
        public int SightedRate { get; set; }
        public int BlindRate { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Place { get; set; }
        public Job SightedJob { get; set; }
        public Job BlindJob { get; set; }
        public Language SightedLang { get; set; }
        public City City { get; set; }
        public Services Service { get; set; }
        public Blind BlindId { get; set; }
        public Sighted SightedPeople { get; set; }
        public string BlindComment { get; set; }
        public string SightedComment { get; set; }
        public Services service { get; set; }

        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public Services services { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
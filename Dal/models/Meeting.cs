using System;
using System.ComponentModel.DataAnnotations;

namespace Dal.models
{
    public class Meeting : IEntity
    {
        [Key] public Guid PostId { get; set; }
        public Post Post { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Place { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int BlindId { get; set; }
        public Blind Blind { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        // feedback
        public string BlindComment { get; set; }
        public string SightedComment { get; set; }
        public int SightedRate { get; set; }
        public int BlindRate { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
using System;

namespace Dal.models
{
    public class PostApplicant : IEntity
    {
        public int Id { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
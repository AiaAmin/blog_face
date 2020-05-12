using System;

namespace Dal.models
{
    public enum PostApplicantStatus
    {
        Applied,
        Rejected,
        Approved
    }

    public class PostApplicant : IEntity
    {
        public int Id { get; set; }
        public Guid SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public PostApplicantStatus Status { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
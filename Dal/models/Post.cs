using System.Net.Mime;
using System;
using System.Collections.Generic;

namespace Dal.models
{
    public enum PostStatus { Open, Closed, Rejected,Approve,Finished };
    public class Post : IEntity
    {
        public Guid Id { get; set; }
        public Guid FinalizedId { get; set; }
        public string Title { get; set; }
        public PostStatus Status{get;set;}
        public string Link { get; set; }
        public string Content { get; set; }
        public int SightedId { get; set; }
        public Sighted Sighted { get; set; }
        public int BlindId { get; set; }
        public Blind Blind { get; set; }
        public List<PostApplicant> PostApplicants { get; set; }
        // todo: add post time
        
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
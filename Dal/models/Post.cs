using System.Net.Mime;
using System;

namespace Dal.models
{
    public class Post : IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public Boolean Status { get; set; }
        public string Content { get; set; }
        public int BlindId { get; set; }
        public Blind Blind { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
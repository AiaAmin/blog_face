using System.Collections.Generic;
using System;

namespace Dal.models
{
    public class Service : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Meeting> Meetings { get; set; }
        public List<SightedService> SightedServices { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
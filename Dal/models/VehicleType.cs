using System;
using System.Collections.Generic;

namespace Dal.models
{
    public class VehicleType : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Sighted> Sighteds { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
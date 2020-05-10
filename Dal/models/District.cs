using System.Collections.Generic;
using System;

namespace Dal.models
{
    public class District : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
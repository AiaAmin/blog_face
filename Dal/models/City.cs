using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dal.models
{
    public class City : IEntity
    {
        public City() { Name = ""; }
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public List<District> Districts { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
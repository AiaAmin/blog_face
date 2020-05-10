using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dal.models
{
    public class Sighted : IEntity
    {
        [Key] public Guid UserId { get; set; }
        public User User { get; set; }

        public string VehicleNumber { get; set; }
        public bool IsQualified { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int ServiceTimeId { get; set; }
        public ServiceTime ServiceTime { get; set; }
        public int ServicesSightedId { get; set; }
        public List<SightedSkill> SightedSkills { get; set; }
        public List<SightedLanguage> SightedLanguages { get; set; }
        public List<SightedService> SightedServices { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
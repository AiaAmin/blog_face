using System;
using System.ComponentModel.DataAnnotations;

namespace Dal.models
{
    public class Sighted : IEntity
    {
        [Key]
        public Guid UserId { get; set;}
        public User User { get; set;}
        
        public string VehicleNumber { get; set;}
        public bool IsQualified { get; set;}
        public int VehicleTypeId { get; set;}
        public VehicleType VehicleType { get; set;}
        public int CityId { get; set; }
        public City city{get;set;}
        public int ServiceTimeId { get; set; }
        public ServiceTime ServiceTime {get;set;}

        public ServicesSighted servicesSighted{get;set;}
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
        public SightedSkills sightedSkills {get;set;}
        public int SightedSkillsId { get; set; }
        public SightedLanguage SightedLanguage{get;set;}
        public int SightedLanguageId { get; set; }
        
    }
}
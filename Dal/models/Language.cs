using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace Dal.models
{
    public class Language:IEntity
    {
        [Key]
        public int id {get;set;}
        public string name {get;set;}
        public SightedLanguage sightedLanguage {get;set;}
        public List<Sighted> sightedPeople {get;set;}
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }   
    }
}
using System;
using System.Collections.Generic;

namespace Dal.models
{
    public class ServiceTime:IEntity
    {
        public int Id {get;set;}
        public DateTime From {get;set;}
        public DateTime To { get; set; }
        public List <Sighted> SightedPeople {get;set;}
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public Service Service{get;set;}
        public int ServiceId{get;set;}
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
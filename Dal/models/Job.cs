using System.Collections.Generic;
using System;
namespace Dal.models
{
    public class Job:IEntity
    {
        public int Id {get;set;}
        public string Name{get;set;}
        
        public List <User> users {get;set;} 
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }

    }
}
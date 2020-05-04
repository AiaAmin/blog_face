using System.Collections.Generic;
namespace Dal.models
{
    public class ServicesSighted
    {
        public int Id{get;set;}
        public List <Services> Services {get;set;}
        public List <Sighted> SightedPeople{get; set;}
    }
}
using System.Collections.Generic;
namespace Dal.models
{
    public class SightedLanguage
    {
        public int Id {get;set;}
        public List <Sighted> SightedPeople {get;set;}
        public List <Language> Languages {get;set;}
    }
}
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dal.models
{
    public class Language : IEntity
    {
        public Language()
        {
            Name = "";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<SightedLanguage> SightedLanguages { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
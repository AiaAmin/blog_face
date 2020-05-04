using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public Blind Blind { get; set; }
        public Sighted Sighted { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte Gender { get; set; }
        public string NationalIdImage { get; set; }
        public string Password { get; set; }
        public City city {get;set;}
        public Job job {get;set;}
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
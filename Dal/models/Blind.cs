using System;
using System.ComponentModel.DataAnnotations;

namespace Dal.models
{
    public class Blind : IEntity
    {
        [Key] public Guid UserId { get; set; }
        public User User { get; set; }
        public string MedicalReportUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastModificationDate { get; set; }
        public Guid ModifierId { get; set; }
    }
}
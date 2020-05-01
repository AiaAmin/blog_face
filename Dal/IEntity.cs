using System;

namespace Dal
{
    public interface IEntity
    {
        DateTime CreationDate { get; set; }
        Guid OwnerId { get; set; }
        DateTime LastModificationDate { get; set; }
        Guid ModifierId { get; set; }
    }
}
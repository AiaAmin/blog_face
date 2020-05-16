using System;
using System.Collections.Generic;
using Dal.models;
namespace Bll
{
    public interface IMeetingMgr
    {
        void Add(Meeting meeting);
        void Edit(Meeting meeting);
        void Remove(Guid id);
        void Start(Guid id);
        void Finish(Guid id);
        List<Meeting> Find(Meeting meeting);
    }
}
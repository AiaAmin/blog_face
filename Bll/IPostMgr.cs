using System;
using System.Collections.Generic;
using Dal.models;
namespace Bll
{
    public interface IPostMgr
    {
        void Add(Post post);
        void Edit(Post post);
        void Remove(Guid id);
        void Close(Guid id);
        void Apply(Guid postId, Guid applicantId);
        void Reject(Guid postId, Guid applicantId);
        void Approve(Guid postId, Guid applicantId);
        void Finish(Guid postId, Guid finalizerId);
        List<Post> Find(Post post, int pgNum, int pgSize);

    }
}
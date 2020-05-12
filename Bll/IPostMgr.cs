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
        void Apply(int postId, int applicantId);
        void Reject(int postId, int applicantId);
        void Approve(int postId, int applicantId);
        void Finish(int postId, int finalizerId);
        List<Post> Find(Post post, int pgNum, int pgSize);

    }
}
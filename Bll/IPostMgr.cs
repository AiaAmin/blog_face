using System.Collections.Generic;
using Dal.models;
namespace Bll
{
    public interface IPostMgr
    {
        void Add(Post post);
        void Edit(Post post);
        void Remove(int id);
        void Close(int id);
        List<Post> Find(Post post);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Dal;
using Dal.models;
using Dal.pgDB;

namespace Bll
{
    public class PostMgr : IPostMgr
    {
        private readonly IRepository<Post> _repositoryPost;

        private readonly IRepository<PostApplicant> _repositoryPostAppl;
        public PostMgr()
        {
            // Bad practice called "tight coupling"
            _repositoryPost = new PgRepository<Post>();
        }
        public void Add(Post post)
        {
            _repositoryPost.Add(post);
        }

        public void Edit(Post post)
        {
            Post existingPost = _repositoryPost.Find().First(p => p.Id == post.Id);
            existingPost.Title = post.Title;
            existingPost.Content=post.Content;
            existingPost.LastModificationDate = DateTime.Now.ToUniversalTime();
            _repositoryPost.Update();
        }

        public void Remove(Guid id)
        {
            Post existingPost = _repositoryPost.Find().First(p => p.Id == id);
            _repositoryPost.Delete(existingPost);
        }
        public List<Post> Find(Post post)
        {
            var q = _repositoryPost.Find();
            if (post.Id !=null)
            {
                return q.Where(p => p.Id == post.Id).ToList();
            }

            if (post.Title.Length > 0)
            {
                q = q.Where(p => p.Title.Contains(post.Title));
            }
            if (post.Content.Length > 0)
            {
                q = q.Where(p => p.Content.Contains(post.Content));
            }


            return q.ToList();
        }
        public void Close(Guid id)
        {
            Post existingPost = _repositoryPost.Find().First(p => p.Id == id); //post
            existingPost.Status = PostStatus.Closed;
            _repositoryPost.Update();
        }
        public void Reject(int postId, int applicantId)
        {
            throw new NotImplementedException();
        }
        public void Finish(int postId, int finalizerId)
        {
            throw new NotImplementedException();
        }

        public List<Post> Find(Post post, int pgNum, int pgSize)
        {
            throw new NotImplementedException();
        }

        public void Approve(int postId, int applicantId)
        {
            throw new NotImplementedException();
        }

        public void Apply(int postId, int applicantId)
        {
            PostApplicant appl = new PostApplicant();
            appl.PostId = postId;
            appl.SightedId = applicantId;
            _repositoryPostAppl.Add(appl);
        }
    }
}
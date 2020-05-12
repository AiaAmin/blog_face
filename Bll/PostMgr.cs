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
        private readonly IRepository<Post> _postRepository;

        private readonly IRepository<PostApplicant> _postApplRepository;

        private readonly IRepository<Sighted> _sightedRepository;

        public PostMgr()
        {
            // Bad practice called "tight coupling"
            _postRepository = new PgRepository<Post>();
            _postApplRepository = new PgRepository<PostApplicant>();
            _sightedRepository = new PgRepository<Sighted>();
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Edit(Post post)
        {
            Post existingPost = _postRepository.Find().First(p => p.Id == post.Id);
            existingPost.Title = post.Title;
            existingPost.Content = post.Content;
            existingPost.LastModificationDate = DateTime.Now.ToUniversalTime();
            _postRepository.Update();
        }

        public void Remove(Guid id)
        {
            Post existingPost = _postRepository.Find().First(p => p.Id == id);
            _postRepository.Delete(existingPost);
        }

        public List<Post> Find(Post post)
        {
            var q = _postRepository.Find();
            if (post.Id != null)
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
            // get the targeted post
            Post existingPost = _postRepository.Find().First(p => p.Id == id);

            // update status flag to be closed
            existingPost.Status = PostStatus.Closed;
            _postRepository.Update();
        }

        public void Reject(Guid postId, Guid applicantId)
        {
            PostApplicant postApplicant = _postApplRepository.Find()
                .FirstOrDefault(p => p.PostId == postId && p.SightedId == applicantId);
            if (postApplicant == null)
            {
                throw new Exception("application not found");
            }

            postApplicant.Status = PostApplicantStatus.Rejected;
            _postApplRepository.Update();
        }

        public void Apply(Guid postId, Guid applicantId)
        {
            // validation
            // check postId existance 
            Post post = _postRepository.Find().FirstOrDefault(p => p.Id == postId);
            if (post == null)
            {
                throw new Exception("post not found");
            }

            // check sightedId existance
            Sighted applicant = _sightedRepository.Find().FirstOrDefault(p => p.UserId == applicantId);
            if (applicant == null)
            {
                throw new Exception("applicant not found");
            }

            // check postApplicant existance
            PostApplicant postAppl = _postApplRepository.Find()
                .FirstOrDefault(p => p.PostId == postId && p.SightedId == applicantId);
            if (postAppl == null)
            {
                throw new Exception("applicant is already applied to post");
            }

            // add a new applicant
            PostApplicant appl = new PostApplicant();
            appl.PostId = postId;
            appl.SightedId = applicantId;
            appl.Status = PostApplicantStatus.Applied;
            _postApplRepository.Add(appl);
        }


        public void Finish(int postId, int finalizerId)
        {
            throw new NotImplementedException();
        }

        public List<Post> Find(Post post, int pgNum, int pgSize)
        {
            IQueryable<Post> q = _postRepository.Find();

            if (post.Title != "")
            {
                q = q.Where(p => p.Title.Contains(post.Title));
            }

            if (post.Content != "")
            {
                q = q.Where(p => p.Content.Contains(post.Content));
            }

            q = q.Where(p => p.Status == post.Status);

            // paging
            int skipped = (pgNum - 1) * pgSize;
            q = q.Skip(skipped).Take(pgSize);

            return q.ToList();
        }

        public void Approve(int postId, int applicantId)
        {
            throw new NotImplementedException();
        }
    }
}
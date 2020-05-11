// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Dal;
// using Dal.models;
// using Dal.pgDB;

// namespace Bll
// {
//     public class PostMgr : 
//     {
//         private readonly IRepository<Post> _repository;

//         public PostMgr()
//         {
//             // Bad practice called "tight coupling"
//         //     _repository = new PgRepository<Post>();
//         // }

//         // public void Add(Post Post)
//         // {
//         //     _repository.Add(Post);
//         // }

//         // public void Edit(Post Post)
//         // {
//         //     Post existingPost = _repository.Find().First(p => p.Id == Post.Id);
//         //     existingPost.Name = Post.Name;
//         //     existingPost.LastModificationDate = DateTime.Now.ToUniversalTime();
//         //     _repository.Update();
//         // }

//         // public void Remove(int id)
//         // {
//         //     Post existingPost = _repository.Find().First(p => p.Id == id);
//         //     _repository.Delete(existingPost);
//         // }

//         // public List<Post> Find(Post Post)
//         // {
//         //     var q = _repository.Find();
//         //     if (Post.Id > 0)
//         //     {
//         //         return q.Where(p => p.Id == Post.Id).ToList();
//         //     }

//         //     if (Post.Name.Length > 0)
//         //     {
//         //         q = q.Where(p => p.Name.Contains(Post.Name));
//         //     }

//         //     return q.ToList();
//         // }

//         // public void Close(int id)
//         // {

//         // }
//     }
// }
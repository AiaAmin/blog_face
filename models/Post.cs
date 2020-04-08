using System;
using System.Collections.Generic;

namespace blog.models
{
    public class Post : BaseModel
    {

        // Property: stronger and secured version of attribute, by which we can prevent primitive obssetion 
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Like> Likes { get; set; }
        public int LikesCount { get; set; }
        public List<Comment> Comments { get; set; }
        public int CommentsCount { get; set; }
        public bool IsPublished { get; set; }
        public User Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
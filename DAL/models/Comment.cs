using System.Collections.Generic;

namespace blog.models
{
    public class Comment : BaseModel
    {
        public User Author { get; set; }
        public Post Post { get; set; }
        public int LikesCount { get; set; }
        public List<Comment> Comments { get; set; }
        public string Content { get; set; }
    }
}
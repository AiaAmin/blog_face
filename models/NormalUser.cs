using System.Collections.Generic;

namespace blog.models
{
    public class NormalUser : User
    {
        public string Gender { get; set; }
        public decimal Age { get; set; }
        public string Location { get; set; }
        public List<string> Ideas { get; set; }
        public List<Post> LikedPosts { get; set; }
        public List<Comment> CommentedPosts { get; set; }
    }
}
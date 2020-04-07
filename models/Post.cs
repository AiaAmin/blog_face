using System;
using System.Collections.Generic;

namespace blog.models
{
    public class Post : BaseModel
    {
        public static int Fake { get; set; }
        public int Real { get; set; }

        // behaviour 
        // Constructor
        public Post()
        {
            Fake = 10;
            Real = 10;
            Title = "Hello";
        }

        // function
        public int UpdateFake()
        {
            Fake++;
            Real++;
            return Fake;
        }

        // States
        // attribute: very weak member that lives in class and shiould be private
        public string title;

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

    public static class PostUtil
    {
        static PostUtil()
        {
        }

        public static int PostCount { get; set; }

        public static int GetPostCount()
        {
            return 10;
        }
    }
}
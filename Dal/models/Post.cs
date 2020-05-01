using System;
using System.Collections.Generic;

namespace Dal.models
{
    public class Post : BaseModel
    {


        public Post()
        {
            Title="Hello";
            Fake=20;

        }

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
        public  static int Fake{get;set;}
        public int CalculateLikeCount()
        {
            //base things which inheritend 
            return this.LikesCount ; //all status or behaviours are in this
        }
    }
    public class Postutil
    {public static  int getPostCount()
    {return 10;}}
}
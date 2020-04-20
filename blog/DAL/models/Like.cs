namespace blog.models
{
    public class Like : BaseModel
    {
        public User Author { get; set; }
        public Post Post { get; set; }
    }
}
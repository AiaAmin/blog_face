using System;
using System.Collections.Generic;

namespace Dal.models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public string Password { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}
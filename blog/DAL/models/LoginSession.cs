using System;

namespace blog.models
{
    public class LoginSession
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public DateTime LoginAt { get; set; }
        public DateTime ExpirtedAt { get; set; }
    }
}
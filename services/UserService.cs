using System;
using System.Linq;
using blog.models;
using blog.memoryDB;

namespace blog.services
{
    public class NormalUserService
    {
        // AddPost => PostService
        // FollowUser 
        // Login 
        public bool Login(string email, string password)
        {
            if (MemoryDB.NormalUsers.Exists(u => u.Email == email && u.Password == password))
            {
                MemoryDB.LoginSessions.Add(new LoginSession()
                {
                    Token = Guid.NewGuid().ToString(),
                    Email = email,
                    LoginAt = DateTime.Now.ToUniversalTime(),
                    ExpirtedAt = DateTime.Now.AddDays(3).ToUniversalTime()
                });
            }

            return false;
        }

        // Signup
        public void SignUp(NormalUser newUser)
        {
            MemoryDB.NormalUsers.Add(newUser);
        }


        // ViewPost => PostService
        // Edit his posts => PostService
        // Delete his posts => PostService
        // BlockUser 
        public void Block(string sessionToken, string blockedUserMail)
        {
            /*LoginSession session = MemoryDB.LoginSessions.First(s =>
                s.Token == sessionToken && s.ExpirtedAt > DateTime.Now.ToUniversalTime());
            
            
            loggedUsr.BlockedUsers.Add(blockedUserMail);
            */
            
        }

        // Logout
        public void Logout(string email)
        {
        }
    }
}
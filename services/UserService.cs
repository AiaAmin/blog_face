using System;
using System.Collections.Generic;
using System.Linq;
using blog.DAL;
using blog.models;
using blog.memoryDB;

namespace blog.services
{
    public class NormalUserService
    {
        private readonly IRepository<NormalUser> _normalsUsersRepo;
        private readonly IRepository<LoginSession> _loginSessionRepo;

        public NormalUserService(IRepository<NormalUser> normalsUsersRepo, IRepository<LoginSession> loginSessionRepo)
        {
            _normalsUsersRepo = normalsUsersRepo;
            _loginSessionRepo = loginSessionRepo;
        }

        // AddPost => PostService
        // FollowUser 
        // Login 
        public bool Login(string email, string password)
        {
            List<NormalUser> usrs = _normalsUsersRepo.Find(new NormalUser() {Email = email, Password = password});
            if (usrs.Count > 0)
            {
                _loginSessionRepo.Add(new LoginSession()
                {
                    Token = Guid.NewGuid().ToString(),
                    Email = email,
                    LoginAt = DateTime.Now.ToUniversalTime(),
                    ExpirtedAt = DateTime.Now.AddDays(3).ToUniversalTime()
                });
                return true;
            }

            return false;
        }

        // Signup
        public void SignUp(NormalUser newUser)
        {
            _normalsUsersRepo.Add(newUser);
        }


        // ViewPost => PostService
        // Edit his posts => PostService
        // Delete his posts => PostService
        // BlockUser 
        public void Block(string sessionToken, string blockedUserMail)
        {
            // 1. Retrieve logged user
            LoginSession session = _loginSessionRepo.FindOne(new LoginSession()
                {Token = sessionToken, ExpirtedAt = DateTime.Now.ToUniversalTime()});

            NormalUser usr = _normalsUsersRepo.FindOne(new NormalUser() {Email = session.Email});

            // 2. Edit loggedUser, to update its blockedUsers with blockedMail
            usr.BlockedUsers.Add(blockedUserMail);
            _normalsUsersRepo.Edit(usr);
        }

        // Logout
        public void Logout(string email)
        {
            // retriev session by email
            LoginSession session = _loginSessionRepo.FindOne(new LoginSession()
                {Email = email, ExpirtedAt = DateTime.Now.ToUniversalTime()});

            // update session's expirydate 
            session.ExpirtedAt = DateTime.Now.ToUniversalTime();
            _loginSessionRepo.Edit(session);
        }
    }
}
using System.Collections.Generic;
using Dal.models;

namespace Dal.memoryDB
{
    public class MemoryDB
    {
        static MemoryDB()
        {
            NormalUsers = new List<NormalUser>();
            LoginSessions = new List<LoginSession>();
        }

        public static List<NormalUser> NormalUsers { get; set; }
        public static List<LoginSession> LoginSessions { get; set; }
    }
}
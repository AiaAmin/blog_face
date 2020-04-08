using System;
using System.Linq;
using blog.memoryDB;
using blog.models;
using blog.services;
using Microsoft.VisualBasic;

namespace blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia from Pradise!");
            NormalUserService userSrv = new NormalUserService();

            for (int i = 0; i < 5; i++)
            {
                userSrv.SignUp(new NormalUser()
                {
                    Email = i + "test@mail.com",
                    Name = "test" + i,
                    Password = "pass"
                });
            }

            Console.WriteLine("Users count is :");
            Console.WriteLine(memoryDB.MemoryDB.NormalUsers.Count);

            // login
            bool logged = userSrv.Login("0test@mail.com", "pass");
            if (logged)
            {
                Console.WriteLine("First login has been done succesfully");
            }


            userSrv.Block("0test@mail.com", "1test@mail.com");

            if (MemoryDB.NormalUsers.First(u => u.Email == "0test@mail.com").BlockedUsers
                .Exists(s => s == "1test@mail.com"))
            {
                Console.WriteLine("User has been blocked successfully");
            }
        }
    }
}
using System;
using Dal.models;
using Dal.pgDB;
using Microsoft.EntityFrameworkCore.Storage;

// using System.Web.Extensions;
// using json.net;

namespace Dal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia from Pradise!");
            
            IRepository<User> userRepo=new PgRepository<User>();
            userRepo.Add(null);
        }
    }
}
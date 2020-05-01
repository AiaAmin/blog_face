using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using Dal.memoryDB;
using Dal.services;
using Dal.DAL;
using Dal.DAL.pgDB;
using Dal.models;
using Microsoft.VisualBasic;
// using System.Web.Extensions;
// using json.net;
using Newtonsoft.Json;

namespace Dal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia from Pradise!");

            // Login
            /*IRepository<NormalUser> normalUserRepo = new MemoryDBRepository<NormalUser>();
            IRepository<LoginSession> loginSesionRepo = new MemoryDBRepository<LoginSession>();
            NormalUserService userSrv = new NormalUserService(normalUserRepo, loginSesionRepo);
            */
            
            IRepository<NormalUser> normalUserRepo=new PgRepository<NormalUser>();
            normalUserRepo.Add(null);
        }

        //read from file
        static void readFromFile(string fileName)
        {
            string text1 = System.IO.File.ReadAllText(fileName);

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text1);
        }
    }
}
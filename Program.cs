using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using blog.DAL;
using blog.memoryDB;
using blog.models;
using blog.services;
using Microsoft.VisualBasic;
// using System.Web.Extensions;
// using json.net;
using Newtonsoft.Json;

namespace blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia from Pradise!");

            // Login
            IRepository<NormalUser> normalUserRepo=new 
            NormalUserService userSrv =new NormalUserService();
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
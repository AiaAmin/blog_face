using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
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

            string text =File.ReadAllText("Users.json");
            Console.WriteLine("Contents of User.json = {0}", text);
            Post pst=new Post(); //int x=10 calling the constructor
            // NormalUserService userSrv = new NormalUserService();
            // for (int i = 0; i < 5; i++)
            // {
            //     userSrv.SignUp(new NormalUser()
            //     {
            //         Email = i + "test@mail.com",
            //         Name = "test" + i,
            //         Password = "pass"
            //     });
            Postutil.getPostCount();

                //read from file
            string text1 = System.IO.File.ReadAllText("Users.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text1);


            // }



            // saveToFile(memoryDB.MemoryDB.NormalUsers,"try2.txt");



            /*// login
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
            }*/


        }

    // static void saveToFile(object data, string fileName)
    // {
    //         // var data = memoryDB.MemoryDB.NormalUsers;
    //         var DatasString = JsonConvert.SerializeObject(data);
    //         // Console.WriteLine(DatasString);
    //         // string filePath = @"Users.json";
    //         using (StreamWriter outputFile = new StreamWriter(fileName))
    //         {
    //             outputFile.WriteLine(DatasString);
    //         }

    //         Console.WriteLine("###Saving data to "+fileName+" is done successfully ###");



    // }


    }

}
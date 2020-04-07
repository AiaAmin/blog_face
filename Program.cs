using System;
using blog.models;
using Microsoft.VisualBasic;

namespace blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia from Pradise!");

            // TypeName VarName = value;
            Console.WriteLine(Post.Fake); // ""
            Post pst = new Post(); // referencType
            pst.UpdateFake();
            Console.WriteLine(Post.Fake); // 11
            Console.WriteLine(pst.Real); // 11
            Post.Fake = 20;
            Post pst2 = new Post();
            Console.WriteLine(Post.Fake); // "10"
            Console.WriteLine(pst2.Real); // 10

            pst.UpdateFake(); //
            Console.WriteLine(Post.Fake); // "11"
            Console.WriteLine(pst2.Real); // 10

        }
    }
}
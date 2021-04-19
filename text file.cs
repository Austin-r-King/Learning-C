using System;
using System.IO;
using static System.IO.File;

namespace txtfile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "/home/user/Documents/FilesForMono/";

            Console.WriteLine("what do you want you file to be named?");
            string name = Console.ReadLine()+".txt";

            File.Create(path+name).Close();


            Console.WriteLine("What do you want to be in your file?");
            string content = Console.ReadLine();

            File.AppendAllText(path + name,content);

            string i = Console.ReadLine();
            while (i != "EXIT")
            {
                File.AppendAllText(path + name, i);
                i = Console.ReadLine();
            }

        }
    }
}

using System;

namespace Numbergussinggame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string Num = ("16");
            Console.WriteLine("Guess my favorate number.");
            Console.WriteLine("");
            Console.WriteLine("*It's less then 20");
            string Gnum = Console.ReadLine();
            if (Gnum == Num)
            {
                Console.WriteLine("congratulations You Won");
            }
            else
            {
                Console.WriteLine("congratulations you failed");
            }

        }
    }
}
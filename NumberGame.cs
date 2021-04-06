using System;

namespace NumberGame
{
    internal static class Program
    {
        public static Program()
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
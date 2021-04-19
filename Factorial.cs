using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to make a factorial stair case to.");
            string input = Console.ReadLine();
            Console.WriteLine("");
            int num = Convert.ToInt32(input);
            int i = 1;
            while (num != 1)
            {
                i = i * num;
                num--;
            }
            Console.WriteLine(i);

        }
    }
}

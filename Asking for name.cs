using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Whats your name?");
            string name =Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("How has your day been?");
            string day = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Good to hear your day was "+day);
            //Don't know if then statements yet
            Console.WriteLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your email so we can keep in touch?");
            string email = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("What is your social sercurity and creadit card number?");
            string SSandCredit = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Any other very personal information you would like me to know about you?");
            string personalInfo = Console.ReadLine();
        }
    }
}

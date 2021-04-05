using System;

namespace ftoc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program is made to convert FAHRENHEIT to CELSIUS or vice versa.");
            Console.WriteLine("Do you want to convert FAHRENHEIT to CELSIUS(press 1)");
            Console.WriteLine("or CELSIUS to FAHRENHEIT(press 2)?");
            Console.WriteLine("");
            string input = Console.ReadLine();
            string one = "1";
            if (one == input)
            {
                Console.WriteLine("PLease input value you would like to convert to CELSIUS");
                int num = Convert.ToInt32(Console.ReadLine());
                num = num - 32;
                Convert.ToDouble(num);
                double num2 = num;
                double num3 = .5556 * num2;
                Console.WriteLine("That is " + num3 + " degrees CELCIUS");
            }
            else
            {
                Console.WriteLine("PLease input value you would like to convert to FAHRENHEIT");
                int num = Convert.ToInt32(Console.ReadLine());
                Convert.ToDouble(num);
                double num2 = num;
                double num3 = num2 * 9/5;
                num3 = num3 + 32;
                Console.WriteLine("That is " + num3 + " degrees FAHRENHEIT");
            }
        }
    }
}

//x= FAHRENHEIT y= CELCIUS
// (x - 32) * .5556 = y
//(y × 9/5) + 32 = x
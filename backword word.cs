using System;
using static System.Console;

namespace backwards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("What would you like me to spell backwards?");
            string txt = ReadLine();
            string array="";
            string reverse ;
            int length = txt.Length;
            int i;
            for (i = length - 1; i > -1; i--)
            {
                reverse = array + txt[i];
                array = reverse;
            }
            Console.WriteLine(array);

        }
    }
    }


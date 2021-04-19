using System;
using System.IO;
using System.Linq;

namespace Sortingleasttogreatest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string file = File.ReadAllText("/home/user/Projects/Sorting-least-to-greatest/list10k.txt");
            string[] split = file.Split(' ');


            string maybe = "good";
            int item = 0;
            int item2 = 1;
            string i = "bad";
            while (i !="done")
            {

                int num = Convert.ToInt32(split[item]);
                int num2 = Convert.ToInt32(split[item2]);

                if (num >= num2)
                {

                }
                else
                {
                    maybe = "bad";
                    string Snum = Convert.ToString(num);
                    string Snum2 = Convert.ToString(num2);
                    split[item] = Snum2;
                    split[item2] = Snum;
                }

                if (item2 == split.Length-3)
                {
                        item = 0;
                        item2 = 1;
                        if (maybe == "bad")
                        {
                            i = "bad";
                            maybe = "good";
                    }
                        else
                        {
                        i = "done";
                    }
                    
                }
                else
                {
                    item++;
                    item2++;

                }
            }



            foreach (var thing in split)
            {
                Console.WriteLine(thing);
            }


        }
    }
    }
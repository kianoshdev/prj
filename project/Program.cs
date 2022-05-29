using System;
using System.Collections.Generic;

namespace program
{
    static class program
    {
        static void Main()
        {
              Console.Write("Pleas Enter sentenses : ");
            string input1 = Console.ReadLine();

            Console.Write("Pleas enter the word : ");
            string input2 = Console.ReadLine();

            bool flag = false;


            // foreach (var item in input1)
            // {
            //     lsit.Add(item);
            // }
            foreach (var item in CostomSplit(input1))
            {
                if (item == input2)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Exist word");
            else
                Console.WriteLine("No exist word");
        }

        public static List<string> CostomSplit(string input)
        {
            List<string> ls = new List<string>();

            string mergchar = "";

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] == ' ')
                {
                    ls.Add(mergchar);
                    mergchar = "";
                }
                else if (i == (input.Length - 1))
                {
                    mergchar += input[i]; 
                    ls.Add(mergchar);
                    mergchar = "";
                }
                else
                    mergchar += input[i];
            }
            return ls;
        }
    }
}
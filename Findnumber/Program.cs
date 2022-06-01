using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[contain]

            //Console.Write("Pleas Enter sentenses : ");
            //string input1 = Console.ReadLine();

            //Console.Write("Pleas enter the word : ");
            //string input2 = Console.ReadLine();

            //Console.WriteLine(costomcontain(input1, input2));

            //[find int]

            Console.Write("Pleas enter big number : ");
            string input1 = Console.ReadLine();

            Console.Write("Pleas enter small number: ");
            string input2 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} is {1} time repeat", input2, costomcontain(input1, input2));
            Console.ResetColor();
        }
        public static int costomcontain(string sen, string wo)
        {

            bool flag = false;
            int Countnum = 0;
            int n = 0;

            // for (int n = 0; n <= sen.Length - 1; n++)
            // {
            // helpint = n;
            for (int i = 0; i <= wo.Length - 1; i++)
            {
                if (n == sen.Length) break;
                if (wo[i] == sen[n])
                {
                    n++;
                    flag = true;
                }
                else
                {
                    i = -1;
                    n++;
                    flag = false;
                }
                if (i == wo.Length - 1)
                {
                    Countnum++;
                    i = -1;
                    n++;
                    continue;
                }
            }
            // Countnum = flag ? Countnum += 1 : Countnum += 0;
            //}
            return Countnum;
        }
    }
}
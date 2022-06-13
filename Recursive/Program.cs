using System;

namespace Recve
{
    static class Program
    {
        static int Helper = 1;
        static int Hleper2 = 0;
        static char[] Reversing(char[] Input, char[] senetenc)
        {
            Hleper2 = Input.Length - Helper;
            if ((Hleper2) >= 0)
            {
                senetenc[Helper - 1] = Input[Hleper2] ;
                Helper++;
                return Reversing(Input, senetenc);
            }
            else
                return senetenc;
        }
        static void Main(string[] args)
        {
            System.Console.Write("Enter the sentences: ");
            string UserSentences = Console.ReadLine();
            char[] senetenc = new char[UserSentences.Length];
            char[] Output = Reversing(UserSentences.ToCharArray(), senetenc);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Revers is: ");
            foreach (var item in Output)
            {
                Console.Write(item);
            }
            Console.ResetColor();
        }
    }
}
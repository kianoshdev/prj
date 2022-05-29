using System;

namespace Program
{
    static class Program
    {
        static void Main()
        {
             Console.Write("Pleas Enter sentenses : ");
            string input1 = Console.ReadLine();

            Console.Write("Pleas enter the word : ");
            string input2 = Console.ReadLine();

            Console.WriteLine(costomcontain(input1, input2));
        }
        public static string costomcontain(String sen, String wo)
        {
            string m = "";
            string m2 = "";
            int n = 0;
            int correctCharCount = 0;
            for (int v = 0; v <= sen.Length - 1; v++)
            {
                n = v;
                if(correctCharCount == wo.Length)
                {
                    break;
                }
                for (int i = 0; i <= wo.Length - 1; i++)
                {
                    if (wo[i] == sen[n])
                    {
                        correctCharCount++;
                        n++;
                    }
                    else
                    {
                        correctCharCount = 0;
                        i--;
                        break;
                    }
                }
            }
            string answer = correctCharCount == wo.Length ? "Exist word" : "Dosent exist word";
            return answer;
        }
    }
}
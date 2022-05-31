using System;
 
 namespace Program
 {
     static class FindWord
     {
         static void Main(string[] args)
        {
            Console.Write("Pleas Enter sentenses : ");
            string input1 = Console.ReadLine();

            Console.Write("Pleas enter the word : ");
            string input2 = Console.ReadLine();

            Console.WriteLine(costomcontain(input1, input2));
        }
        public static string costomcontain(string sen, string wo)
        {
            int n = 0;
            bool flag = false;
            for (int i = 0; i <= wo.Length - 1; i++)
            {
                if (n == sen.Length)
                {
                    flag = false;
                    break;
                }
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
            }
            string answer = flag ? "Exist word" : "Dosent exist word";
            return answer;
        }
    }
}
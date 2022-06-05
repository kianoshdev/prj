using System;
using System.Collections.Generic;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BetForOutinLoop = 0;
            string SoFar = "";
            bool Flag = false;
            int Helper = 0;
            string World = "";
            string FinalContant = "";
            Random random = new Random();
            Category category = new Category();
            Graphic graphic = new Graphic();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello welcome to hangman game\n" +
                "pleas choose one category [ 1- Clothes, 2- Car, 3- Fruit ]\nEnter the categurys number: ");
            Int16 Number = Convert.ToInt16(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    int index1 = random.Next(category.cloths.Count);
                    string Content1 = category.cloths[index1];
                    FinalContant = Content1;
                    break;
                case 2:
                    int index2 = random.Next(category.car.Count);
                    string Contant2 = category.car[index2];
                    FinalContant = Contant2;
                    break;
                case 3:
                    int index3 = random.Next(category.fruit.Count);
                    string Contant3 = category.fruit[index3];
                    FinalContant = Contant3;
                    break;
            }

            string[] WorldArrey = new string[FinalContant.Length];

            for (int i = 0; i <= FinalContant.Length - 1; i++)
            {
                World += " _ ";
                WorldArrey[i] += " _ ";
            }

            while (Helper <= 6 )
            {
                int Count = 0;
                Console.WriteLine("\n" + World);
                Console.WriteLine("\nGuessd letter so far: " + SoFar);
                if (BetForOutinLoop == FinalContant.Length) { break; }
                Console.Write("\nEnter letter: ");
                char Input = Convert.ToChar(Console.ReadLine());
                if (FinalContant.Contains(Input.ToString().ToUpper()))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int q = 0; q <= FinalContant.Length - 1; q++)
                    {
                        if (Input.ToString().ToUpper() == FinalContant[q].ToString())
                        {
                            WorldArrey[q] += FinalContant[q];
                            Count += 1;
                            BetForOutinLoop += 1;
                        }
                    }
                    if (Helper >= 1)
                    {
                        Console.WriteLine(graphic.HangmanShaps[Helper - 1]);
                    }
                    Flag = true;
                }

                if (Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    SoFar += (Input + " ");
                    Console.WriteLine(graphic.HangmanShaps[Helper]);
                    Helper += 1;
                    Flag = false;
                }

                World = "";
                for (int i = 0; i <= FinalContant.Length - 1; i++)
                {
                    World += WorldArrey[i];
                }
            }
            string Output = Flag ? "\n\n\n                    YOU ARE WIN ;)" : "\n\n\n                    YOU ARE LOSS ;)";
            Console.WriteLine(Output);
            foreach (var item in graphic.Hangmantxt)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();
        }
    }
}


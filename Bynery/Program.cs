using System;

namespace Bynery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [Bynery2to10]

            Console.WriteLine("Enter the number(just 0 and 1): ");
            string input = Console.ReadLine();

            double recursiv(string input, int Length, int length1)
            {
                if (Length > 0)
                {
                    return int.Parse(input[Length - 1].ToString()) * Math.Pow(2, length1 - Length) + recursiv(input, Length - 1, length1);
                }
                else
                {
                    return 0;
                }

            }
            Console.WriteLine($"Bynery2to10({input}): {recursiv(input, input.Length, input.Length)}");
            #endregion

            #region [Bynry10to2]

            Console.WriteLine("Enter the number: ");
            int input1 = Convert.ToInt16(Console.ReadLine());

            string Bynry10to2(int input)
            {
                if (input >= 2)
                {
                    return (input % 2).ToString() + Bynry10to2(input / 2) ;
                }
                else
                    return input.ToString();
            }
            Console.WriteLine($"Bynry10to2({input1}): {Bynry10to2(input1)}");
            #endregion

            #region [Bynery10to16]

            Console.WriteLine("Enter the number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            string ABCDE(int Input)
            {
                switch (Input)
                {
                    case 10:
                        return "A";
                    case 11:
                        return "B";
                    case 12:
                        return "C";
                    case 13:
                        return "D";
                    case 14:
                        return "E";
                    case 15:
                        return "F";
                    default:
                        return Input.ToString();
                }
            }

            string Bynry10to16(int Input)
            {
                if (Input >= 16)
                {
                    return  Bynry10to16(Input / 16) + ABCDE(Input % 16);
                }
                else
                {
                    return Input.ToString();
                }
            }

            Console.WriteLine($"Bynery10to16({input2}): {Bynry10to16(input2)}");

            #endregion

            #region [Bynery16t010]
            Console.Write("Enter your number: ");
            string input3 = Console.ReadLine();
            
            int ABCDEF(char input)
            {
                switch (input)
                {
                    case 'A':
                        return 10;
                    case 'B':
                        return 11;
                    case 'C':
                        return 12;
                    case 'D':
                        return 13;
                    case 'E':
                        return 14;
                    case 'F':
                        return 15;
                    default:
                        return Convert.ToInt32(input);
                }

            }

            double Bynery16t010(string input,int lengthInput, int lengthInput1)
            {
                if (lengthInput1 > 0)
                {
                    return ABCDEF(input[lengthInput1 - 1]) * Math.Pow(16, lengthInput - lengthInput1) + Bynery16t010(input, lengthInput, lengthInput1 - 1);
                }
                else
                    return 0;
            }

            Console.WriteLine($"Bynery16t010({input3}): {Bynery16t010(input3,input3.Length, input3.Length)}");
            #endregion
        }
    }
}

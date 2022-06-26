using System;
using System.Collections.Generic;
using System.Linq;

namespace EventPractic
{
    internal class Program
    {
        public class person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public bool Permission { get; set; }
            public person()
            {
                Permission = false;
            }
            public event EventHandler Blocked;

            public void Answer(object sender, EventArgs e)
            {
                Console.WriteLine("\nYou are blocked ==========");
            }
            public void Checked()
            {
                if(Permission == false)
                {
                    Blocked?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("\nNo problem your no block /////////");
                }
            }
        }
        static void Main(string[] args)
        {
            List<person> PersonList = new List<person>()
            {
                new person() { Name ="Kianosh", LastName = "Sheybaie",Permission = true},
                new person() { Name ="Kiarash", LastName = "Davodi",Permission = false},
                new person() { Name ="Amir", LastName = "Barekati",Permission = false},
            };

            person ObjP = new person();

            Console.Write("Enter your name: ");
            ObjP.Name = Console.ReadLine();
            do
            {
                ConsoleKeyInfo Input = Console.ReadKey();
                if(Input.Key == ConsoleKey.Spacebar)
                {
                    Console.Write("\nEnter your lastname: ");
                    ObjP.LastName = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("\nEnter Space for enter your lastname");
                }
            } while (true);

            int Count = PersonList.Where( i => i.Name == ObjP.Name && i.LastName == ObjP.LastName ).Count();

            if(Count >= 1)
            {
                Console.WriteLine("\nyour specifications are exist");
            }
            else
            {
                PersonList.Add(ObjP);
                Console.WriteLine($"\nWelcom Miss/Mr {ObjP.Name} {ObjP.LastName}");
            }

            ObjP.Blocked += ObjP.Answer;
            ObjP.Checked();
        }
    }
}

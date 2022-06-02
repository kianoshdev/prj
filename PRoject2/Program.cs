using System;
using System.Collections.Generic;

namespace Project
{
    static class Project
    {
        static void Main(string[] Args)
        {
            List<Person> ls = new List<Person>();

            System.Console.Write("How many are your human : ");
            int number = Convert.ToInt16(Console.ReadLine());
            int i = 1;

            while (i <= number)
            {
                Console.WriteLine($"\nPerson {i}");

                System.Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                System.Console.Write("Enter your salary: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                System.Console.Write("Enter your Work hour: ");
                int whour = Convert.ToInt32(Console.ReadLine());

                Person pr = new Person(name, whour, salary);

                ls.Add(pr);

                i++;

                Console.WriteLine("=====================");
            }

            foreach (var item in ls)
            {
                int q = 1;
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"\n---------Person{q}---------\nName: {item.Name} \nSalary: {item.Salary} \nWork hour: {item.Whour}");
                q++;
            }
            Console.ResetColor();
        }
    }
}

public class Person
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _salary;
    public int Salary
    {
        get { return _salary; }
        set
        {
            while (value == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write("you cant enter 0, pleas enter another number \nEnter your salary: ");
                value = Convert.ToInt32(Console.ReadLine());
                if (value != 0) { _salary = value; break; }
            }
        }
    }

    private int _whour;
    public int Whour
    {
        get { return _whour; }
        set { _whour = value; }
    }

    public Person(string name, int whour, int salary)
    {
        Name = name;
        Salary = salary;
        Whour = whour;
    }

}
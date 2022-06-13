// using System;
// using System.Collections.Generic;

// namespace Project
// {
//     static class Project
//     {
//         static void Main(string[] Args)
//         {
//             List<Person> ls = new List<Person>();

//             System.Console.Write("How many are your human : ");
//             int number = Convert.ToInt16(Console.ReadLine());
//             int i = 1;

//             while (i <= number)
//             {
//                 Console.WriteLine($"\nPerson {i}");

//                 System.Console.Write("Enter your name: ");
//                 string name = Console.ReadLine();

//                 System.Console.Write("Enter your salary: ");
//                 int salary = Convert.ToInt32(Console.ReadLine());

//                 System.Console.Write("Enter your Work hour: ");
//                 int whour = Convert.ToInt32(Console.ReadLine());

//                 Person pr = new Person(name, whour, salary);

//                 ls.Add(pr);

//                 i++;

//                 Console.WriteLine("=====================");
//             }

//             foreach (var item in ls)
//             {
//                 int q = 1;
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 System.Console.WriteLine($"\n---------Person{q}---------\nName: {item.Name} \nSalary: {item.Salary} \nWork hour: {item.Whour}");
//                 q++;
//             }
//             Console.ResetColor();
//         }
//     }
// }

// public class Person
// {
//     private string _name;
//     public string Name
//     {
//         get { return _name; }
//         set { _name = value; }
//     }

//     private int _salary;
//     public int Salary
//     {
//         get { return _salary; }
//         set
//         {
//             while (value == 0)
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 System.Console.Write("you cant enter 0, pleas enter another number \nEnter your salary: ");
//                 value = Convert.ToInt32(Console.ReadLine());
//                 if (value != 0) { _salary = value; break; }
//             }
//         }
//     }

//     private int _whour;
//     public int Whour
//     {
//         get { return _whour; }
//         set { _whour = value; }
//     }

//     public Person(string name, int whour, int salary)
//     {
//         Name = name;
//         Salary = salary;
//         Whour = whour;
//     }

// }
// namespace structur 
// {
//     static class Program
//     {
//         public struct structrpr
//         {
//             public int tol { get; set; }
//             public int arz;

//             public structrpr(int r, int y)
//             {
//                 tol = r;
//                 arz = y;
//                 System.Console.WriteLine( r * y);
//             }
//         }

//         static void Main()
//         {
//             structrpr str = new structrpr(5,6);
//             System.Console.WriteLine(str);
//         }
//     }
// }
// using System;

// namespace overloding
// {
//     static class Program
//     {
//         public class overloading
//         {
//            public string Add(string m, string n)
//             {
//                 return m + n;
//             }
//            public int Add(int m, int n)
//             {
//                 return m + n;
//             }
//         }
//         static void Main()
//         {
//             overloading m = new overloading();
//             System.Console.WriteLine(m.Add(8,9));
//             System.Console.WriteLine(m.Add("j","jh"));
//         }
//     }
// }
// using System;
// namespace IntefacePr
// {
//     static class Program
//     {
//         public interface Verb
//         {
//             public string mohtva { get; set; }
//             string ridan();
//         }
//         public class Person
//         {
//             public string Name { get; set; }
//             public Person(string name)
//             {
//                 Name = name;
//             }
//         }
//         public class child : Person , Verb
//         {
//             public child(string name) : base(name)
//             {
//                 mohtva = "ghahveie";
//                 System.Console.WriteLine(mohtva+'\n'+Name);
//             }

//             public string mohtva { get ; set ; }

//             public string ridan()
//             {
//                 return "bobobob";
//             }
//         }
//         static void Main()
//         {
//             System.Console.WriteLine(new child("koko").ridan());
//         }
//     }
// }
// using System;
// namespace inheritctor
// {
//     static class Program
//     {
//         public class Person
//         {
//             public string Name { get; set; }
//             public Person(string name)
//             {
//                 Name = name;
//             }
//             public Person()
//             {
                
//             }
//         }
//         public class child : Person 
//         {
//             public string  FirstName { get; set; }
//             public int Age { get; set; }
//             public child(string name, string firstname) 
//             {
//                 Name = name;
//                 FirstName = firstname;
//                 System.Console.WriteLine("ctor 1");
//             }
//             public child(int age, string firstname) 
//             {
//                 FirstName = firstname;
//                 Age = age;
//                 System.Console.WriteLine("ctor 3");
//             }
//             public child(int age,string c, string firstname) : this(age,firstname)
//             {
//                 Name = c;
//                 Age = age; 
//                 System.Console.WriteLine("ctor 2");
//             }
//         }
//         static void Main()
//         {
//             System.Console.WriteLine(new child(12 ,"kianosh","kiarash"));
//         }
//     }
// }
// using System;
//  namespace abstractclass
//  {
//      static class Program
//      {
//          public abstract class abs
//          {
//              public void talk()
//              {
//                  System.Console.WriteLine("iam abstract");
//              }
//              public abstract void run();
//              public virtual string food()
//              {
//                  return "pizza";
//              }
//          }

//         public class child : abs
//         {
//             public override void run()
//             {
//                 throw new NotImplementedException();
//             }
//             public override string food()
//             {
//                 return "khiar";
//             }
//         }

//         static void Main()
//          {
//              System.Console.WriteLine(new child().food());
//          }
//      }
//  }
// using System;

// namespace v
// {
//     static class Program
//     {
//         interface Voic
//         {
//             string vic { get; set; }

//             string enfajr();
//         }
//         public class Car
//         {
//             public string NameCar { get; set; }
//             public Car(string name)
//             {
//                 NameCar = name;
//             }
//         }
//         public class Human
//         {
//             public string NameHuman { get; set; }
//             public Human(string name)
//             {
//                 NameHuman = name;
//             }
//         }
//         public class Prid : Car , Voic
//         {
//             public Prid(string name, string vic) : base(name)
//             {
//                 this.vic = vic;
//             }

//             public string vic { get ; set ;}

//             public string enfajr()
//             {
//                 return vic;
//             }
//         }
//         public class kianosh : Human , Voic
//         {
//             public kianosh(string name, string vic) : base(name)
//             {
//                 this.vic = vic;
//             }

//             public string vic { get ; set ; }

//             public string enfajr()
//             {
//                 return vic;
//             }
//         }
//         static void Main()
//         {
//            kianosh man = new kianosh("kianosh","Aaaaaaaa");
//            Prid pri = new Prid("pride","booom");
//            System.Console.WriteLine(man.enfajr() + '\n' + pri.enfajr());
//         }
//     }
// }
using System;
 namespace abc
 {
     static class Program 
     {
         public abstract class Person : Man
         {
             public Person()
             {
                 
             }
             public void Talk()
             {
                 System.Console.WriteLine("im kinasoh");
             }

             public virtual string Run()
             {
                 return "virtual class";
             }

             public abstract int Age();
         }

        public class Man 
        {
            public int MyProperty { get; set; }
            public void m()
            {
                System.Console.WriteLine("mmmmm");
            }
        }
        public class nam : Person
        {
            public override int Age()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
         {
             nam n = new nam();
             n.m();
         }
     }
 }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec22_2PM
{
    public class StudentInfo2
    {
        public static List<Student> Std;
        static StudentInfo2()
        {
            Std = new List<Student>()
            {
                new Student() { Id = 1, name = "Suresh", adress = "Hydrabad", age = 22 },
                new Student() { Id = 2, name = "Narendra", adress = "Benguluru", age = 24 },
                new Student() { Id = 3, name = "Pavan Kumar", adress = "Telangana", age = 22 }
            };
        }
        static void Display()
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|ID |  Name         | Address       | Age |");
            Console.WriteLine("|---|---------------|---------------|-----|");
            Std.ForEach(x => { Console.WriteLine("|{0,-3}|{1,-15}|{2,-15}|{3}   |", x.Id, x.name, x.adress, x.age); });
            Console.WriteLine("|___|_______________|_______________|_____|");
        }
        static void DisplayById(int a)
        {
            Student onevalue = Std.Where(x => x.Id == a).FirstOrDefault<Student>();
            if (onevalue == null)
            {
                Console.WriteLine("No Matching Id");
            }
            else
            {
                Console.WriteLine(" ____________________________________________");
                Console.WriteLine("|  ID  |  Name         | Address       | Age |");
                Console.WriteLine("|------|---------------|---------------|-----|");
                Console.WriteLine("|{0,-6}|{1,-15}|{2,-15}|{3}   |", onevalue.Id, onevalue.name, onevalue.adress, onevalue.age);
                Console.WriteLine("|______|_______________|_______________|_____|");
            }
        }
        static void DisplayByName(string a)
        {
            Student onevalue = Std.Where(x => x.name == a).FirstOrDefault<Student>();
            if (onevalue == null)
            {
                Console.WriteLine("No Matching Name here");
            }
            else
            {
                Console.WriteLine(" ____________________________________________");
                Console.WriteLine("|  ID  |  Name         | Address       | Age |");
                Console.WriteLine("|------|---------------|---------------|-----|");
                Console.WriteLine("|{0,-6}|{1,-15}|{2,-15}|{3}   |", onevalue.Id, onevalue.name, onevalue.adress, onevalue.age);
                Console.WriteLine("|______|_______________|_______________|_____|");
            }
        }
        static void AddValues()
        {
            Student s1 = new Student()
            {
                Id = Convert.ToInt32(Console.ReadLine()),
                name = Console.ReadLine(),
                adress = Console.ReadLine(),
                age = Convert.ToInt32(Console.ReadLine())
            };
            Std.Add(s1);
        }

        static void Delete(int iddd)
        {
            Std.RemoveAt(iddd);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("1.display All values\n2.Adding Values\n3.Search by Student Id\n4.Search By student Name\n5.Remove Students");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Display();
            }
            else if (c == 2)
            {
                Console.WriteLine("How many Number of Students do you want to add");
                int n1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n1; i++)
                {
                    Console.WriteLine($"Enter ID ,Name , Address and Age of {i} Student");
                    AddValues();
                }
                Display();
            }
            else if (c == 3)
            {
                Console.WriteLine("Enter Student id");
                int id1 = Convert.ToInt32(Console.ReadLine());
                DisplayById(id1);
            }
            else if (c == 4)
            {
                Console.WriteLine("Enter Student Name");
                string namee = Console.ReadLine();
                DisplayByName(namee);
            }
            else if (c == 5)
            {
                Console.WriteLine("Enter Student Index");
                int idd = Convert.ToInt32(Console.ReadLine());
                int c1 = idd - 1;
                Delete(c1);
                Console.WriteLine("\nAfter Removing students List");
                Display();
            }
            else
            {
                Console.WriteLine("Wrong choice, please select a valid option");
                Main(args);
            }
            Console.WriteLine("\n1. Continue Process or Press Any number to Exit");
            int c2 = Convert.ToInt32(Console.ReadLine());
            if (c2 == 1)
            {
                Main(args);
            }
            else
            {
                // You can optionally include some exit logic here.
            }
        }
    }
}

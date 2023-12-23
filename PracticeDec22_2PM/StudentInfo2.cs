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
       public List<Student> Std;
        public StudentInfo2()
        {
            Std = new List<Student>()
            {
                 new Student(){Id=1,name="Suresh",adress="Hydrabad",age=22 },
                 new Student(){Id=2,name="Narendra",adress="Benguluru",age=24},
                 new Student(){Id=3,name="Pavan Kumar",adress="Telangana",age=22}
            };
        }
        void display()
        {
             Console.WriteLine(" _________________________________________");
             Console.WriteLine("|ID |  Name         | Address       | Age |");
             Console.WriteLine("|---|---------------|---------------|-----|");
             Std.ToList().ForEach(x => { Console.WriteLine("|{0,-3}|{1,-15}|{2,-15}|{3}   |",x.Id,x.name,x.adress,x.age); });
             Console.WriteLine("|___|_______________|_______________|_____|");
        }
        void displayById(int a)
        {
            Student onevalue=Std.Where(x=>x.Id==a).FirstOrDefault<Student>();
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
                Console.WriteLine("|______|________|__________|_______|");
            }
        }
        void displayByName(string a)
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
                Console.WriteLine("|______|________|__________|_______|");
            }
        }
        void addValues()
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
        public static void Main(string[] args) 
        {
            StudentInfo2 x1= new StudentInfo2();
            Console.WriteLine("1.display All values\n2.Adding Values\n3.Search by Student Id\n4.Search By student Name");
            int c=Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                x1.display();
            }
            else if (c == 2)
            {
                Console.WriteLine("How meny Number of Students do you wants to add");
                int n1=Convert.ToInt32(Console.ReadLine());
                for(int i=1; i<=n1;i++)
                {
                    Console.WriteLine($"Enter ID ,Name , Address and Age of {i} Student");
                    x1.addValues();
                }
                x1.display();
            }
            else if(c == 3)
            {
                Console.WriteLine("Enter Student id");
                int id1=Convert.ToInt32(Console.ReadLine());
                x1.displayById(id1);
            }
            else if( c == 4)
            {
                Console.WriteLine("Enter Student Name");
                string namee=Console.ReadLine();
                x1.displayByName(namee);
            }
            else
            {
                Console.WriteLine("Wrong choise plese select valid opti0n");
                Main(args);
            }
        }
    }
}   

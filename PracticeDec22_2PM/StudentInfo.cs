using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec22_2PM
{
    public class StudentInfo
    {
        static void Main(string[] args)
        {
            List<Student> d = new List<Student>() {
        new Student(){Id=1,name="Suresh",adress="Kadapa",age=22},
        new Student(){Id=2,name="suchi",adress="Nadyala",age=22},
        new Student(){Id=3,name="Ragendhu",adress="Benguluru",age=22}
        };
            var all=d.ToList();
            d.ToList().ForEach(x => Console.WriteLine("|{0} name {1} Adress {2} Age {3}",x.Id,x.name,x.adress,x.age+"|"));
        }
    }
} 

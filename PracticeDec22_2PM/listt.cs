using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec22_2PM
{
    public class listt
    {
        static void doubleLink()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("a");
            list.AddFirst("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddBefore(list.First, "g");
            list.RemoveFirst();
            list.RemoveLast();
            //string[] arr = new string[5];
            //list.copyto(arr, 3);
            //for (int i = 0; i < arr.length; i++)
            //{
            //    console.writeline(arr[i]);
            //}
            foreach (string s in list)
            {
                Console.WriteLine(s);

            }
        }
        static void Main(string[] args)
        {
            doubleLink();
        }
    }
}

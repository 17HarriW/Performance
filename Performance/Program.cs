using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    class Program
    {
        static void Test()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < 220000000; i++)
            {
                myList.Add(i);
            }
        }
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < 2; i++)
                Test();
            s.Stop();
            Console.WriteLine($"{s.ElapsedMilliseconds}ms taken");

            Console.ReadLine();
        }
    }
}

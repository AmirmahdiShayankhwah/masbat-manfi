using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(System.Console.ReadLine());
            if (a > 1)
                Console.WriteLine("mosbat");
            else if (a < 0)
                Console.WriteLine("manfi");

            Console.ReadKey();

        }
    }
}

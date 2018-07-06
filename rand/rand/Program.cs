using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("press anything for number");
            for (int i = 1; i < 10000; i++)
            {               
                Random randnum = new Random();
                r = randnum.Next(1, 377);
                Console.WriteLine(r);
                Console.ReadKey();
            }

        }
    }
}

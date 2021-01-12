using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    // Afisati toti divizorii numarului n. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg: ");
            int n, d;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Divizorii intregi ai numarului n sunt: ");
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0)
                    Console.Write($"{-d},{d},");
            }

            Console.ReadKey();
        }
    }
}

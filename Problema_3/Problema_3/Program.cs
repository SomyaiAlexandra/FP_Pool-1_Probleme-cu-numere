using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificare daca n il divide pe k.");
            int n, k;
            Console.Write("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar: ");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
                Console.WriteLine($"{n} DA se divide cu {k}.");
            else
                Console.WriteLine($"{n} NU se divide cu {k}.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere: ");
            int a, b, c;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());

            if ((a <= b + c) && (b <= a + c) && (c <= a + b))
                Console.WriteLine($"Laturile de lungime {a}, {b} si {c} DA pot forma un triunghi.");
            else
                Console.WriteLine($"Laturile de lungime {a}, {b} si {c} NU pot forma un triunghi.");
            Console.ReadKey();
        }
    }
}

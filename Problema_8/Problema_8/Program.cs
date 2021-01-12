using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    //Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
    //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 2 numere: ");
            int a, b;
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Inainte de inversare: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Dupa inversare: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.ReadKey();
        }
    }
}

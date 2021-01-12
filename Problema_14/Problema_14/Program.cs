using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_14

//Determianti daca un numar n este palindrom.

{
    class Palindrom
    {
        
        static void is_palindrom(int n)
        {
            int m = n;
            int p = 0;

            while (n > 0)
            {
                p = p * 10 + n % 10;
                n = n / 10;
            }
            if (p == m)
                Console.WriteLine($"Numarul {m} DA este palindrom.");
            else
                Console.WriteLine($"Numarul {m} NU este palindrom.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar!");

                is_palindrom(n);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
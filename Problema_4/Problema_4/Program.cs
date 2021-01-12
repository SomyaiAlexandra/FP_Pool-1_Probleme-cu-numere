using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        // Detreminati daca un an y este an bisect. 
        static void Main(string[] args)
        {
            Console.Write("Introduceti un an ");
            int y;
            y = int.Parse(Console.ReadLine());

            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                Console.WriteLine($"Anul {y} E BISECT");
            else
                Console.WriteLine($"Anul {y} NU E BISECT");
            Console.ReadKey();
        }
    }
}

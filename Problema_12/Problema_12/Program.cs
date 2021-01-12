using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12
{
    //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg de la tastatura: ");
            int n, a, b, nr = 0;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.WriteLine("Introduceti capetele unui interval de numere intregi: ");

                Console.Write("a: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write("b: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                    throw new Exception("Nu ati introdus un numar !");

                if (a == b)
                {
                    throw new Exception("Nu aveti un interval de numere intregi!");
                }
                else if (a < b)
                {
                    for (int i = a; i <= b; i++)
                    {
                        if (i % n == 0)
                            nr++;
                    }
                    Console.WriteLine($"in intervalul [{a},{b}] avem {nr} numere divizibile cu numarul {n}");

                }
                else
                {
                    for (int i = b; i <= a; i++)
                    {
                        if (i % n == 0)
                            nr++;
                    }
                    Console.WriteLine($"in intervalul [{b},{a}] avem {nr} divizibile cu numarul {n}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

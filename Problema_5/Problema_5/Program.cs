﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. 
    //Cifrele se numara de la dreapta la stanga. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar n: ");
            int n;
            n = int.Parse(Console.ReadLine());
            string N;
            N = Convert.ToString(n);

            Console.Write("Introduceti un numar k (mai mic sau egal cu numarul de cifre al lui n): ");
            int k;
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < N.Count(); i++)
            {
                if (i == N.Count() - k)
                    Console.WriteLine($"A {k}-a cifra de la capatul numarului este: {N[i]}");
            }
            Console.ReadKey();
        }
    }
}

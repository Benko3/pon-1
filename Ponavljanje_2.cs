﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;
            double c = 12.5;
            double d = 16.7;
            double x = (a + b + c + d) / 4;
            Console.WriteLine("Prosječna vrijednost {0}", +x);
            Console.ReadKey();
        }
    }
}

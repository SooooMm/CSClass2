﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(65432);
            Wanted<double> wantedDouble = new Wanted<double>(3.141592);


            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);

        }
    }
}
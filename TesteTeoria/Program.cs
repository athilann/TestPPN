﻿using System;

namespace TesteTeoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var particula = new Particula(0,4, 0, 0);
            Console.WriteLine("----Inicio----");


            Console.WriteLine("V: " + particula.V);
            Console.WriteLine("M: " + particula.M);
            Console.WriteLine("E: " + particula.E);
            Console.WriteLine("G: " + particula.G);
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("");

            var count = 1;
            while (count < 300)
            {
                Console.WriteLine("----Clico " + count + " ----");
                particula.Run();
                Console.WriteLine("V: " + particula.V);
                Console.WriteLine("M: " + particula.M);
                Console.WriteLine("E: " + particula.E);
                Console.WriteLine("G: " + particula.G);
                Console.WriteLine("-----------------");
                Console.WriteLine("");
                Console.WriteLine("");
                count++;
            }
            Console.ReadLine();

        }
    }
}

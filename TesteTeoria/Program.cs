using System;

namespace TesteTeoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var particula = new Particula(5, 0, 0, 0);
            Console.WriteLine("----Inicio----");


            Console.WriteLine("V: " + particula.V);
            Console.WriteLine("M: " + particula.M);
            Console.WriteLine("E: " + particula.E);
            Console.WriteLine("G: " + particula.G);
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("");

            var count = 1;
            while (particula.M != 0)
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

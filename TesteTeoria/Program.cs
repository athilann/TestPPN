using System;

namespace TesteTeoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var particula = new Massa(4);
            Console.WriteLine("----Inicio----");


            Console.WriteLine("Tempo: " + particula.Tempo);
            Console.WriteLine("Espaco: " + particula.Espaco);
            Console.WriteLine("NP: " + particula._NP);
            Console.WriteLine("P: " + particula._P);
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("");

            var count = 1;
            while (count < 300)
            {
                Console.WriteLine("----Clico " + count + " ----");
                particula.Run();
                Console.WriteLine("Tempo: " + particula.Tempo);
                Console.WriteLine("Espaco: " + particula.Espaco);
                Console.WriteLine("NP: " + particula._NP);
                Console.WriteLine("P: " + particula._P);
                Console.WriteLine("-----------------");
                Console.WriteLine("");
                Console.WriteLine("");
                count++;
            }
            Console.ReadLine();

        }
    }
}

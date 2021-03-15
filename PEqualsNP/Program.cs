using System;
using System.Collections.Generic;

namespace PEqualsNP
{
    class Program
    {

        public static List<Elemento> elementos = new List<Elemento>()
        {
            new Elemento
            {
                Name = "Hydrogen",
                Protons = 1,
                Neutrons = 0,
                Eletrons = 1,
            },
            new Elemento
            {
                Name = "Helium",
                Protons = 2,
                Neutrons = 2,
                Eletrons = 1,
            },
            new Elemento
            {
                Name = "Lithium",
                Protons = 3,
                Neutrons = 4,
                Eletrons = 2,
            },
            new Elemento
            {
                Name = "Beryllium",
                Protons = 4,
                Neutrons = 5,
                Eletrons = 2,
            },
            new Elemento
            {
                Name = "Boron",
                Protons = 5,
                Neutrons = 6,
                Eletrons = 2,
            },
            new Elemento
            {
                Name = "Carbon",
                Protons = 6,
                Neutrons = 6,
                Eletrons = 2,
            },
            new Elemento
            {
                Name = "Nitrogen",
                Protons = 7,
                Neutrons = 7,
                Eletrons = 2,
            },
            new Elemento
            {
                Name = "Oxygen",
                Protons = 8,
                Neutrons = 8,
                Eletrons = 2,
            },
            new Elemento
            {
                Name = "Fluorine",
                Protons = 9,
                Neutrons = 10,
                Eletrons = 2,
            },
        };

        //public static int[] PrimosNaturais = { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991 };

        static void Main(string[] args)
        {

            Console.WriteLine("----------------------------------------");
            foreach (var elemento in elementos)
            {
                elemento.Entropia = 1;
                Console.WriteLine($" A = { elemento.A} \n" +
                                  $" Elemento = { elemento.Name} \n" +
                                  $" N = {elemento.Neutrons} \n" +
                                  $" P = { elemento.Protons} \n" +
                                  $" E = {elemento.Eletrons} \n" +
                                  $" Neutralidade ={elemento.Neutralidade} \n" +
                                  $" Carga eletrica ={elemento.CargaEletrica} \n" +
                                  $" CN = {elemento.CargaNeutra} \n" +
                                  $" Espaco  = {elemento.Espaco} \n" +
                                  $" EstadoXYZ = {elemento.EstadoXYZ} \n" +
                                  $" Carga = { elemento.Carga} \n" +
                                  $" EstadoEletrico = { elemento.EstadoEletrico} \n" +
                                  $" EstadoNeutro = { elemento.EstadoEnergetico}");

                Console.WriteLine("----------------------------------------");
            }
        }




    }
}

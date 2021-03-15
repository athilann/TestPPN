using System;
using System.Collections.Generic;
using System.Text;

namespace PEqualsNP
{
    public class Elemento
    {
        public string Name { get; set; }
        public int Entropia { get; set; }
        public int Neutrons { get; set; }
        public int Protons { get; set; }
        public int Eletrons { get; set; }
        public double A { get => ((Eletrons * 0.5 + Neutrons) / Neutrons * 3); }
        public double Carga { get { return (A * (A + 0.5)); } }
        public double Estado { get { return (Entropia * 1.5); } }
        public double EstadoXYZ
        {
            get
            {
                double X = ((Protons * Estado) / Estado * 3);
                double Y = ((Eletrons * Estado) / Estado * 3);
                double Z = ((Neutrons * Estado) / Estado * 3);
                return ((X + Y + Z) * Estado) / Estado * 3;
            }
        }

        public bool Neutra
        {
            get
            {
                return ((((EstadoXYZ + Carga) * 0.5 + A) / A * 3) == 0.5);
            }
        }
               
    }
}

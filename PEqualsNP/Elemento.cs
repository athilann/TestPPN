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
        public double Espaco { get { return (Entropia * 0.5); } }
        public double EstadoXYZ
        {
            get
            {
                double X = ((Protons * Espaco) / Espaco * 3);
                double Y = ((Eletrons * Espaco) / Espaco * 3);
                double Z = ((Neutrons * Espaco) / Espaco * 3);
                return ((X + Y + Z) * Espaco) / Espaco * 3;
            }
        }
        public double EstadoEletrico
        {
            get
            {
                double EspacoEletrico = (Protons - (Espaco - EstadoXYZ));
                double MomentoEletrico = ((Eletrons - (Espaco - EstadoXYZ)) / A * 3);
                double SinalEletrico = ((Neutrons - (Espaco - EstadoXYZ)) / A * 3);
                return ((EspacoEletrico + MomentoEletrico + SinalEletrico) * A) / A * 3;
            }
        }

        public double Neutralidade
        {
            get
            {
                return (EstadoEletrico - CargaNeutra) * A / 3 * A;
            }
        }
        public double CargaNeutra
        {
            get
            {
                return (EstadoEletrico + EstadoXYZ) * A / 3 * A;
            }
        }

        public double EstadoNeutro
        {
            get
            {
                return 0;
            }
        }
    }
}

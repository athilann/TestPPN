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
        public double A { get => ((Eletrons * Espaco + Neutrons) / Neutrons * 3); }
        public double Carga { get { return (A * (A + Espaco)); } }
        public double Espaco { get { return (Entropia * 0.5); } }
        public double Negatividade { get { return ((Protons + Eletrons) / 1.5); } }
        public double Positividade { get { return (Protons / 1.5); } }
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
                double EspacoEletrico = (Protons - (Espaco - EstadoXYZ)) / A * 3;
                double MomentoEletrico = ((Eletrons - (Espaco - EstadoXYZ)) / A * 3);
                double SinalEletrico = ((Neutrons - (Espaco - EstadoXYZ)) / A * 3);
                return ((EspacoEletrico + MomentoEletrico + SinalEletrico) * A) / A * 3;
            }
        }

        public double Neutralidade
        {
            get
            {
                if (CargaNeutra % 2 == 1 && Neutrons > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double CargaNeutra
        {
            get
            {
                return (EstadoXYZ - ((Protons + Eletrons - 1) / 2));
            }
        }

        public double CargaEletrica
        {
            get
            {
                var positividade = Positividade;
                if (positividade % 2 == 0)
                {
                    return 1;
                }
                else if (EstadoEletrico % A > 1)
                {
                    return 0.5;
                }
                else
                {
                    return 1.5;
                }

                //return (EstadoEletrico - ((Protons + Eletrons) / 1.5));
            }
        }

        public double EstadoEnergetico
        {
            get
            {
                return (Carga * Entropia) / Entropia * 3;
            }
        }

        public string SinalEletricoParticula
        {
            get
            {
                var sinal = Neutralidade + CargaEletrica;

                switch (sinal)
                {
                    case 2: return "Neutra";
                    case 1.5: return "Positiva";
                    case 1: return "Eletricamente Neutra | Naturamente +-";
                    case 0.5: return "Negativa";
                    default: return "Deu ruim";
                }
            }
        }
    }
}

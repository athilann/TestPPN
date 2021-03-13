using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTeoria
{
    public class Particula
    {
        private double _v = 0;  // Backing store
        private double _m = 0;  // Backing store
        private double _e = 0;  // Backing store
        private double _g = 0;  // Backing store

        public double V { get => _m + _v; set { _v += value; } }
        public double M { get => _v - _g; set { _m += value; } }
        public double E { get => _v * _m; set { _e = value; } }
        public double G { get => _m + _e ; set { _g = value; } }

        public Particula(double v, double m, double e, double g)
        {
            V = v;
            M = m;
            E = e;
            G = g;
        }

        public void Run()
        {
            V = V;
            M = M;
            E = E;
            G = G;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTeoria
{
    public class Particula
    {
        private decimal _v = 0;  // Backing store
        private decimal _m = 0;  // Backing store
        private decimal _e = 0;  // Backing store
        private decimal _g = 0;  // Backing store

        public decimal V { get => _m + _v; set { _v += value; } }
        public decimal M { get => _v - _g; set { _m += value; } }
        public decimal E { get => _v + _m; set { _e = value; } }
        public decimal G { get => _m + _e; set { _g = value; } }

        public Particula(int v, int m, int e, int g)
        {
            V = v;
            M = M;
            E = E;
            G = G;
        }

        public void Run()
        {
            M = M;
            V = V;
            E = E;
            G = G;
        }


    }
}

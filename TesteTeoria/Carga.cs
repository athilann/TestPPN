using System;

namespace TesteTeoria
{
    internal class Carga
    {
        private Particula particula;

        private int Energia { get => particula.elemento.massa._NP - particula.Potencia; }

        public Carga(Particula particula)
        {
            this.particula = particula;
        }

        internal void Run()
        {
            particula.elemento.massa._NP -= Energia;
        }
    }
}
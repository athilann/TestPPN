using System;
using System.Collections.Generic;

namespace TesteTeoria
{
    internal class Particula
    {
        public int _NC;

        public Elemento elemento;

        private int Tempo { get => elemento.Tempo + Potencia; }
        public int Potencia { get => _NC - elemento.Gravidade; }

        private List<Carga> Cargas { get; set; }

        public Particula(Elemento elemento)
        {
            this.elemento = elemento;
        }

        private void CriarParticulas(int numeroDeParticulas)
        {
            _NC = numeroDeParticulas;
            Cargas = new List<Carga>();
            while (numeroDeParticulas <= Cargas.Count)
            {
                Cargas.Add(new Carga(this));
            }
        }

        internal void Run()
        {
            foreach (var carga in Cargas)
            {
                carga.Run();
            }
        }
    }
}
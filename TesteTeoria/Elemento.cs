using System;
using System.Collections.Generic;

namespace TesteTeoria
{
    public class Elemento
    {
        public int _NE;
        public Massa massa;
        private List<Particula> Particulas { get; set; }

        public int Tempo { get => massa.Tempo + Gravidade; }
        public int Gravidade { get => _NE - massa.Espaco; }

        public Elemento(Massa massa)
        {
            this.massa = massa;
            CriarParticulas(massa._NP);
        }

        private void CriarParticulas(int numeroDeParticulas)
        {
            Particulas = new List<Particula>();
            _NE = numeroDeParticulas;
            while (numeroDeParticulas <= Particulas.Count)
            {
                Particulas.Add(new Particula(this));
            }
        }

        internal void Run()
        {
            foreach (var particula in Particulas)
            {
                particula.Run();
            }
        }
    }
}
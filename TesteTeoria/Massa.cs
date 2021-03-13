using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTeoria
{
    public class Massa
    {
        private int _P;
        public int _NP;
        private int _espaco;
        private int _tempo;


        private List<Elemento> Elementos { get; set; }
        public int Espaco { get=> _NP + _espaco; set => _espaco = value; }
        public int Tempo { get=> _NP - _espaco; set => _tempo = value; }


        public Massa(int numerodeElementos)
        {
            _P = numerodeElementos;
            CriarElementos(_P);           
        }

        private void CriarElementos(int numeroDeParticulas)
        {
            _NP = numeroDeParticulas;
            while (numeroDeParticulas <= Elementos.Count)
            {
                Elementos = new List<Elemento>();
                Elementos.Add(new Elemento(this));
            }
        }

        public void Run()
        {
            if (_NP == 0)
            {
                CriarElementos(_P);
            }
            
            foreach (var particula in Elementos)
            {
                particula.Run();
            }
           
        }


    }
}

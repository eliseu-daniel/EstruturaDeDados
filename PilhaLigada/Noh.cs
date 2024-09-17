using System;

namespace PilhaLigada
{
    internal class Noh
    {
        string valor;
        Noh anterior;

        public string Valor
        {
            get { return valor;}
            set { valor = value;}
        }

        public Noh Anterior
        {
            get { return anterior;}
            set { anterior = value;}
        }
    }
}
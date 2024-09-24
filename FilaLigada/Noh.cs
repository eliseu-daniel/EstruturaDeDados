using System;

namespace FilaLigada
{
    internal class Noh
    {
        string valor;

        Noh proximo;

        public string Valor
        {
            get { return valor;}
            set { valor = value;}
        }

        public Noh Proximo
        {
            get { return proximo;}
            set { proximo = value;}
        }
    }
}
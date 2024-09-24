using System;

namespace PilhaLigada
{
    internal class Noh
    {
        string valor;

        // objeto da classe Noh
        Noh anterior;

        // criar novos dados
        public string Valor
        {
            get { return valor;}
            set { valor = value;}
        }

        // para alterar os dados passados anteriormente
        public Noh Anterior
        {
            get { return anterior;}
            set { anterior = value;}
        }
    }
}
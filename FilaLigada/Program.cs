using System;

namespace FilaLigada
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Fila Ligada");

            Fila agenda = new Fila();

            agenda.Enfileirar("1");
            agenda.Imprimir();
        }
    }
}
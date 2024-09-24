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
            agenda.Enfileirar("2");
            agenda.Imprimir();
            System.Console.WriteLine();
            agenda.Desenfileirar();
            System.Console.WriteLine();
            System.Console.WriteLine("Tirando o 1");
            System.Console.WriteLine();
            agenda.Imprimir();
        }
    }
}
using System;

namespace ListaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista Estatica");
            Console.WriteLine();
            Console.WriteLine();

            int Tamanho;
            Console.WriteLine("Qual Tamanho da Lista?");
            Tamanho = Convert.ToInt32(Console.ReadLine());

            Lista Agenda = new Lista(Tamanho);

            Agenda.Inserir("A");
            Agenda.Inserir("B");
            Agenda.Inserir("C");
            Agenda.Inserir("D");
            Agenda.Inserir("E", 1);


            Console.ReadKey();
        }
    }
}
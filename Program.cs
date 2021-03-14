using System;

namespace Pasta_Visual
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros;
            double cm = 100;
            double km = 1000;

            Console.Write("Digite Seu Número: ");
            metros = double.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Seu Valor de Metros para Centimetros: ");
            Console.WriteLine($"{metros * cm}");

            Console.Write("Seu valor de Metros para KM: ");
            Console.WriteLine($"{metros / km}");
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}

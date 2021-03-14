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

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite Seu Número: ");
            metros = double.Parse(Console.ReadLine());
            Console.Write("\n");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Seu Valor de Metros para Centimetros: ");
            Console.WriteLine($"{metros * cm}");
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Seu valor de Metros para KM: ");
            Console.WriteLine($"{metros / km}");
            Console.Write("\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}

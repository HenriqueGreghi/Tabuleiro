using System;

namespace Tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calc = new Calculo();
            
            Console.WriteLine("Entre com a dimenção do tabuleiro: ");
            calc.dimencao = int.Parse(Console.ReadLine());

            calc.Calcular();
            calc.Imprimir();
            

        }
    }
}

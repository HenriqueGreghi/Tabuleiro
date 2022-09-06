using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Calculo
    {
        private int A { get; set; }
        private int B { get; set; }
        private int N { get; set; }
        public int dimencao { get; set; }

        public void Calcular()
        {
            N = dimencao * dimencao;
            if (N % 2 == 0)
            {
                A = N / 2;
                B = A;
                
            }
            else
            {
                A = (N + 1) / 2;
                B = A - 1;
                
            }
        }
        public void Imprimir()
        {
            Console.WriteLine(A + " casas brancas e " + B + " casas pretas.");
        }
    }
}

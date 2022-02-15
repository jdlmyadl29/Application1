using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment11
{
    class Program
    {
        public string difAbsoluta(int[,] matriz)
        {
            string mensaje = "";
            int sum1 = 0;
            for (int i = 0, j = matriz.GetLength(1) - 1; i < matriz.GetLength(0); i++, j--)
            {
                sum1 += matriz[i, j];

            }
            int sum2 = 0;
            for (int i = 0, j = 0; i < matriz.GetLength(0); i++, j++)
            {
                sum2 += matriz[i, j];

            }
            int difAbsoluta = Math.Abs(sum1 - sum2);
            mensaje = "La diferencia absoluta de la matriz es: " + difAbsoluta;
            return mensaje;

        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            int[,] matriz =
            {
                {1, 2, 3},
                {4, 5, 6},
                {9, 8, 9}
            };
            Console.WriteLine(p1.difAbsoluta(matriz));
            Console.ReadKey();
        }
    }
}

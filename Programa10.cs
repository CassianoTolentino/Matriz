using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz 
{
    class Matriz
    {
        static int numeroLinhas = 3, numeroColunas = 3;
        static int[,] matrizInteiros = new int[numeroLinhas, numeroColunas];

        public static void imprimeMatriz()
        {
            Console.WriteLine("\nImpressão da matriz: \n");
            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    Console.Write(matrizInteiros[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    Console.WriteLine("Insira o valor que será inserido na linha " + i + " e na coluna " + j);
                    matrizInteiros[i, j] = int.Parse(Console.ReadLine());
                }
            }

            imprimeMatriz();

            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    for (int k = 0; k < numeroColunas - j - 1; k++)
                    {
                        if (matrizInteiros[i, k] > matrizInteiros[i, k + 1])
                        {
                            int temp = matrizInteiros[i, k];
                            matrizInteiros[i, k] = matrizInteiros[i, k + 1];
                            matrizInteiros[i, k + 1] = temp;
                        }
                    }
                }
            }

            imprimeMatriz();

            Console.ReadKey();


        }
    }
}

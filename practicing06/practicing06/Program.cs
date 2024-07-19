using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int m, n;
            int[,] matriz;

            Console.WriteLine("Insira abaixo o numero: ");

            string[] vetor = Console.ReadLine().Split(' ');
            m = int.Parse(vetor[0]);
            n = int.Parse(vetor[1]);

            matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {

                vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)

                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            int[] vet = new int[m];

            for (int i = 0; i < m; i++)
            {
                int soma = 0;
                for (int j = 0; j < n; j++)
                {
                    soma = soma + matriz[i, j];
                }

                vet[i] = soma;

            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
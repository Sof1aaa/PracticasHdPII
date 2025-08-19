using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVec
{
    internal class Program
    {
        static void Llenar(int[] v1, int[] v2, int n)
        {
            var rand = new Random();

            Console.Write("Vector 1: ");
            for (int i = 0; i < n; i++)
            {
                v1[i] = rand.Next(1, 11);
                Console.Write(v1[i] + " ");
            }

            Console.Write("\nVector 2: ");
            for (int i = 0; i < n; i++)
            {
                v2[i] = rand.Next(1, 11);
                Console.Write(v2[i] + " ");
            }
            Console.WriteLine();
        }

        static void Operaciones(int[] v1, int[] v2, int n)
        {
            int[] suma = new int[n];
            int[] resta = new int[n];
            int[] multiplicacion = new int[n];
            double[] division = new double[n];

            for (int i = 0; i < n; i++)
            {
                suma[i] = v1[i] + v2[i];
                resta[i] = v1[i] - v2[i];
                multiplicacion[i] = v1[i] * v2[i];
                division[i] = Math.Round((double)v1[i] / v2[i], 2);
            }

            Console.WriteLine("\nSuma:");
            for (int i = 0; i < n; i++)
                Console.Write(suma[i] + " ");

            Console.WriteLine("\nResta:");
            for (int i = 0; i < n; i++)
                Console.Write(resta[i] + " ");

            Console.WriteLine("\nMultiplicación:");
            for (int i = 0; i < n; i++)
                Console.Write(multiplicacion[i] + " ");

            Console.WriteLine("\nDivisión:");
            for (int i = 0; i < n; i++)
                Console.Write(division[i] + " ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Digite cantidad de números: ");
            int n = int.Parse(Console.ReadLine());

            int[] vec1 = new int[n];
            int[] vec2 = new int[n];

            Llenar(vec1, vec2, n);
            Operaciones(vec1, vec2, n);

            Console.ReadKey();
        }
    }
}
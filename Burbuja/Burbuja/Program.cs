using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    internal class Program
    {
        static void Llenar(int[] v1, int n)
        {
            var rand = new Random();

            Console.Write("Vec: ");
            for (int i = 0; i < n; i++)
            {
                v1[i] = rand.Next(1, 100);
                Console.Write(v1[i] + " ");
            }
        }

        static void Burbuja(int[] v1, int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j=i; j<n; j++)
                {
                    if(v1[i]> v1[j])
                    {
                        int aux = v1[i];
                        v1[i] = v1[j];
                        v1[j]=aux;
                    }
                }
            }
            Console.Write("Vec ordenado: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v1[i] + " ");
            }
        }

            static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeritos: ");
            int n = int.Parse(Console.ReadLine());
            int[] vec1 = new int[n];

            Llenar(vec1,n);
            Burbuja(vec1, n);

            Console.ReadKey();
        }
    }
}

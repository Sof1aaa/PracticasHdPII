using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoArreglos
{
    internal class Program
    {
        static void Llena(int n)
        {
            int[] vec = new int[n];
            int i = 0, num;
            var rand = new Random();
            while (i < n)
            {
                vec[i] = rand.Next(50);
                Console.WriteLine(vec[i]);
                i++;
            }
            Console.WriteLine("Digite un numero");
            num = int.Parse(Console.ReadLine());
            Buscar(num, vec, n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite cantidad de numeros");
            int n=int.Parse(Console.ReadLine());
            Llena(n);
            Console.ReadKey();
        
        }
        static void Buscar(int num, int[] vec, int n)
            {
            int con=0, i;
            for (i = 0; i < vec.Length; i++)
            {
                if (vec[i] == num)
                {
                    Console.WriteLine("El numero se encuentra en la posicion " + (i + 1));
                    con++;
                }
            }
            if (con < 1)
            {
                Console.WriteLine("El numero no se encuentra en el arreglo");
            }
        }
    }
}
               
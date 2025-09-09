using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wform09092025
{
    internal class Operaciones
    {
        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }

        public int Factorial(int a, int fac)
        {
            for (int i = 1; i <= a; i++)
            {
                fac *= i;
            }
            return fac;
        }

        public int Sumatoria(int a, int sumatoria)
        {
            for (int i = 1; i <= a; i++)
            {
                sumatoria += i;
            }
            return sumatoria;
        }

        public int Fibonacci(int a)
        {
            int n1 = 0;
            int n2 = 1;

            for (int i = 0; i < a; i++)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp + n2;
            }
            return n1; //Ta malito, me rindo
        }
    }

}

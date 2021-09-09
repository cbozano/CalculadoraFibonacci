using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFibonacci
{
    class CalculadoraFibonacci
    {
        public double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public int Fibonacci(int numero)
        {
            if (numero <= 1)
            {
                return numero;
            }
            else
            {
                return Fibonacci(numero - 1) + Fibonacci(numero - 2);
            }


        }
        public static int Factorial(int numero)
        {
            if (numero <= 1)
            {
                return 1;
            }
            else
            {
                return numero * Factorial(numero - 1);
            }
        }
    }
}

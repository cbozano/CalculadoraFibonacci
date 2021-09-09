using System;

namespace CalculadoraFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;

            Calculadora calculo = new Calculadora();

            double result = calculo.Suma(num1, num2);


            Console.WriteLine(result);
        }
    }
}

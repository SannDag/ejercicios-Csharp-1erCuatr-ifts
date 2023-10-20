using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 5:
//La serie de Fibonacci, es una sucesión infinita de números en los que cada uno de ellos es el resultado de la suma de sus dos términos anteriores:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89…
//Por definición matemática es una sucesión recurrente, es decir que se necesitan calcular los términos anteriores bajo la misma definición para conseguir uno de sus números.
//Desarrollar un programa que implemente la función recursiva para calcularla.

namespace TP1_EJ5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese número para ejecutar la serie de Fibonacci:");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write(fibonacci(i) + " ");            
            }            

            Console.ReadKey();
        }

        static int fibonacci(int num) {

            //caso base
            if (num <= 1) {
                return num;
            } else {
                return fibonacci(num - 1) + fibonacci(num - 2);
            }
        }
    }
}

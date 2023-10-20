using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa para obtener el factorial de un número.
//Recordar que el factorial de un número es el resultado que se obtiene de multiplicar dicho número por el anterior y así sucesivamente hasta llegar a uno.
//Ej. el factorial de 4 es 4 * 3 * 2 * 1 es decir 24.

namespace TP1_EJ3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Ingrese un número para calcular su factorial:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(num));
            Console.ReadKey();

        }

        static int factorial(int num) {

            //caso base
            if (num == 1 || num == 0) { 
                return 1;
            }

            return num * factorial(num - 1);
        }
    }
}

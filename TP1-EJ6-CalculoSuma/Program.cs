using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_EJ6_CalculoSuma
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Ingrese numero para calcular su suma:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(calcularSuma(num));

            Console.ReadKey();

        }


        static int calcularSuma(int num) {

            //caso base
            if (num < 10)
            {
                return num;
            }
            else {
                return num % 10 + calcularSuma(num / 10);
            } 
        }
    }
}

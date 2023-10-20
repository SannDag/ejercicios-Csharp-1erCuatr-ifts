using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 4:
//Escribir un programa que utilice una función recursiva que calcule a^n.

namespace CalculoPotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, potencia;

            Console.WriteLine("Ingrese número");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese potencia para realizar el cálculo:");
            potencia = int.Parse(Console.ReadLine());

            Console.WriteLine(calculoPotencia(num, potencia));

            Console.ReadKey();
        }

        static int calculoPotencia(int num, int potencia) {

            //caso base
            if (potencia == 0) {
                return 1;
            } else if (potencia == 1) {
                return num;
            }

            return num * calculoPotencia(num,potencia-1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)


/*
 Calcular e informar el promedio de los números pares menores a un valor definido por el usuario.
Dicho número no debe ser superior a 1500.
 */
namespace PromedioNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {

            double promedio;
            int pares=0,contadorPares=1, input;

            Console.WriteLine("Ingrese un valor para calcular el promedio de los numeros pares: ");
            input = int.Parse(Console.ReadLine());

            if (input <= 1500)
            {
                for (int i = 1; i < input; i++)
                {
                    if (i % 2 == 0)
                    {
                        pares += i;
                        contadorPares++;                        
                    }
                }
            }
            else 
            {
                Console.WriteLine("Debe ingresar un valor menor o = a 1500");
            }

            promedio = pares / contadorPares;

            Console.WriteLine("Total suma pares: " + pares);
            Console.WriteLine("Contador pares: " + contadorPares);

            Console.WriteLine("El promedio de los numeros pares menores al numero " + input + ", ingresado por el usuario, es: " + promedio);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 6:
//Ingresar un vector de 10 elementos enteros. Generar con él otros dos vectores: 1 con los elementos positivos y el otro con los elementos negativos
//(los ceros no se asignan a ninguno de los 2 vectores).
//Del vector de positivos (si existe) calcular e informar el promedio de sus elementos.
//Del vector de negativos (si existe) calcular e informar el menor elemento.

namespace VectoresPositivosNegativos
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, posN = 0, posP = 0, totalPositivos=0,promedioPositivos=0;
            int[] enteros = new int[10];
            int[] positivos = new int[10];
            int[] negativos = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entero:");
                enteros[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                if (enteros[i] > 0)
                {
                    positivos[posP] = enteros[i];
                    totalPositivos += positivos[posP];
                    posP++;
                }
                else if (enteros[i] < 0)
                {

                    negativos[posN] = enteros[i];
                    posN++;
                }
            }

            if (posP == 0)
            {
                Console.WriteLine("No se generó el vector de positivos");
            }
            else
            {
                Console.WriteLine("El vector de positivos es:");

                for (i = 0; i < posP; i++)
                {
                    Console.Write(positivos[i] + " ");
                }
                Console.WriteLine("\n");

                Console.WriteLine("El promedio de todos los positivos es:");

                Console.WriteLine(promedioPositivos = totalPositivos / posP);
            }



            if (posN == 0)
            {
                Console.WriteLine("No se generó el vector de negativos");
            }
            else
            {
                int menorN = negativos[0];

                for (i = 1; i < posN; i++)
                {
                    if (negativos[i] < menorN)
                    {
                        menorN = negativos[i];
                    }
                }               

                Console.WriteLine("Elementos negativos:");
                for (i = 0; i < posN; i++)
                {
                    Console.WriteLine(negativos[i]);
                }

                Console.WriteLine("El menor elemento de los negativos es: " + menorN);
                
            }

            Console.ReadKey();
        }
    }
}


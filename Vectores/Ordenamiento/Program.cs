using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vec = new int[] { 6, 25, 4, 3, 2, 8, 5, 19, 12, 1 };

            Console.WriteLine("Vector desordenado:");
            imprimirVector(vec); //desordenado

            Console.WriteLine("Vector ordenado:");
            ordenamiento(vec); //ordenado
            imprimirVector(vec);

            Console.WriteLine("Indice del valor buscado: " + busqueda(vec, 4));
            Console.WriteLine("Buscamos valor inválido, devuelve '-1':" + busqueda(vec, 84)); //buscamos valor invalido, devuelve -1

            Console.WriteLine("Probamos otro metodo de busca, devuelve su indice: " + busq(vec, 5));
            Console.ReadKey();
        }

        public static void ordenamiento(int[] arr)
        {
            int aux;
            int cap = 10;
            for (int i = 0; i < cap; i++)
            {
                for (int j = 0; j < cap - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        aux = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = aux;
                    }
                }
            }
        }

        static int busqueda(int[] arr, int value)
        {

            int cap = 10;

            for (int i = 0; i < cap; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static void imprimirVector(int[] arr)
        {
            int cap = 10;
            for (int i = 0; i < cap; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n");
        }

        //ejemplo 2 de busqueda
        static int busq(int[] array, int val)
        {
            int i = 0;
            int pos = -1;
            int cap = 10;

            while (i < cap && pos < 0)
            {
                if (array[i] == val)
                {
                    return i;
                }

                i++;
            }

            return -1;

        }
    }
}

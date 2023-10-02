using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)

/*Realizar un programa que permita cargar dos listas de 15 valores cada una. Informar con un mensaje
cuál de las dos listas tiene un valor acumulado mayor (mensajes "Lista 1 mayor", "Lista 2 mayor",
"Listas iguales")*/


namespace valores_lista
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalLista1 = 0, totalLista2 = 0, lista1 = 0, lista2 = 0;

            for (int i = 0; i < 15; i++) {

                Console.WriteLine("(lista1)" + i + " Ingrese un valor:");
                lista1 = int.Parse(Console.ReadLine());

                totalLista1 += lista1;

            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("(lista2)" + i + "Ingrese un valor:");
                lista2 = int.Parse(Console.ReadLine());

                totalLista2 += lista2;
            }

            if (totalLista1 > totalLista2)
            {
                Console.WriteLine("Lista 1 mayor: " + totalLista1);
            }
            else if (totalLista2 > totalLista1)
            {
                Console.WriteLine("Lista 2 mayor: " + totalLista2);
            }
            else 
            {
                Console.WriteLine("Las listas son iguales");
            }

            Console.ReadKey();

        }
    }
}

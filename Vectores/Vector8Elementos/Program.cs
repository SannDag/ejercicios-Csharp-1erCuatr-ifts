using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 3:
//Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
//El valor acumulado de todos los elementos del vector.
//El valor acumulado de los elementos del vector que sean mayores a 36.
//Cantidad de valores mayores a 50.

namespace Vector8Elementos
{
    class Program
    {
        static void Main(string[] args)
        {
            int capVector = 8;
            float[] vector8Elementos = new float[8];
            float valor, totalVector=0, mayoresA36=0, cantidadMayoresA50=0;

            for(int i = 0; i < capVector; i++)
            {
                Console.WriteLine("Ingrese un valor:");
                valor = float.Parse(Console.ReadLine());

                vector8Elementos[i] = valor;
                totalVector += vector8Elementos[i];

                if (vector8Elementos[i] > 36)
                {
                    mayoresA36 += vector8Elementos[i];
                }
                
                if (vector8Elementos[i] > 50)
                {
                    cantidadMayoresA50++;
                }
            }

            Console.WriteLine("Valor acumulado del vector: {0}", totalVector);
            Console.WriteLine("Valor acumulado de los elementos del vector mayores a 36: {0}", mayoresA36);
            Console.WriteLine("Cantidad de valores mayores a 50: {0}", cantidadMayoresA50);

            Console.ReadKey();

        }
    }
}

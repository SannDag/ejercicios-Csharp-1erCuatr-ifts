using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Condición: resolver con lo visto en la cursada

/*
 Se ingresan: Número de sucursal y total recaudado en pesos de las 15 sucursales de un negocio.
Luego se ingresan el número de la sucursal y la cantidad de dinero recaudado en el día. 
Este conjunto finaliza al ingresar número de sucursal 0 (inexistente).
Se pide:
a) Resolver correctamente lo solicitado en el enunciado anterior.
b) Buscar el número de sucursal (Método secuencial). Si existe, actualizar el total recaudado. Si no existe, informar "Numero de sucursal inexistente".
c) Ordenar los vectores por número de sucursal de mayor a menor, con arraste del total recaudado. (Método de la burbuja)
d) En el programa principal mostrar los vectores
 */

namespace RecaudadoSucursalBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, k, cap = 3, numSucursal;
            float dineroRecaudadoDia=0;
            int[] sucursales = new int[cap];
            float[] totalRecaudado = new float[cap];

            //Se ingresan: Número de sucursal y total recaudado en pesos de las 15 sucursales de un negocio.
            for (i = 0; i < cap; i++)
            {
                Console.WriteLine("*****Ingreso inicial*****");
                Console.WriteLine("Ingrese numero de sucursal");
                sucursales[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese total recaudado");
                totalRecaudado[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------\n");

            }

            //Luego se ingresan el número de la sucursal y la cantidad de dinero recaudado en el día.
            Console.WriteLine("Ingrese numero de sucursal del día");
            numSucursal = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese total recaudado del día");
            dineroRecaudadoDia = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero de sucursal ingresado: {0}", numSucursal + "\n");

            //Este conjunto finaliza al ingresar número de sucursal 0(inexistente).            
            while (numSucursal != 0)
            {
                //b) Buscar el número de sucursal(Método secuencial).Si existe, actualizar el total recaudado. Si no existe, informar "Numero de sucursal inexistente".
                //*****Búsqueda por metodo secuencial*****"
                busqueda(numSucursal,sucursales, totalRecaudado, dineroRecaudadoDia);

                //c) Ordenar los vectores por número de sucursal de mayor a menor, con arrastre del total recaudado. (Método de la burbuja)
                //*****Ordenamiento búrbuja*****
                ordenamiento(sucursales, totalRecaudado);

                Console.WriteLine("Ingrese numero de sucursal para seguir operando o 0 para finalizar:");
                numSucursal = int.Parse(Console.ReadLine());

                if (numSucursal != 0) {
                    Console.WriteLine("Ingrese total recaudado");
                    dineroRecaudadoDia = float.Parse(Console.ReadLine());
                }
            }

            //d) En el programa principal mostrar los vectores
            Console.WriteLine("Informe de vectores ordenados de mayor a menor:");
            for (i = 0; i < 3; i++)
            {
                Console.Write("Sucursal:" + sucursales[i] + "\n");
                Console.Write("Total recaudado:" + totalRecaudado[i] + "\n");
            }

            Console.ReadKey();
        }

        //static void informeVectores(int [] array)
        //{
        //    int cap = 5;

        //    for (int i = 0; i < array[cap]; i++)
        //    {
        //        Console.WriteLine("Informe: " + array[i]);
        //    }       
        
        //}

        static void ordenamiento(int [] sucursales, float [] totalRecaudado)
        {
            int i, k, x, aux1;
            float aux2;

            k = 0;
            x = 3;
            while (k == 0)
            {
                k = 1;
                x--;

                for (i = 0; i < x; i++)
                {
                    if (sucursales[i] < sucursales[i + 1])
                    {
                        k = 0;
                        aux1 = sucursales[i];
                        sucursales[i] = sucursales[i + 1];
                        sucursales[i + 1] = aux1;

                        aux2 = totalRecaudado[i];
                        totalRecaudado[i] = totalRecaudado[i + 1];
                        totalRecaudado[i + 1] = aux2;
                    }
                }
            }

            ////informe vector ordenado
            //for (i = 0; i < capArray; i++)
            //{
            //    Console.WriteLine("N° Sucursal: " + sucursales[i]);
            //    Console.WriteLine("Total Recaudado: " + totalRecaudado[i]);
            //}
            //Console.WriteLine("\n");
        }

        static void busqueda(int numSuc, int [] sucursales, float []totalRecaudado, float dineroRecaudadoDia) {
            int cap = 3,k,i;
            k = 0;
            i = 0;

            while (k == 0 && i < cap)
            {
                if (numSuc == sucursales[i])
                {
                    k = 1;
                }
                else
                {
                    i++;
                }
            }

            if (k == 0)
            {
                Console.WriteLine("Numero de sucursal inexistente");
            }
            else
            {
                Console.WriteLine("Total recaudado antes de actualizar: {0}", totalRecaudado[i]);
                totalRecaudado[i] += dineroRecaudadoDia;
                Console.WriteLine("Se actualiza total recaudado: {0}", totalRecaudado[i] + "\n");
            }

        }
    }
}

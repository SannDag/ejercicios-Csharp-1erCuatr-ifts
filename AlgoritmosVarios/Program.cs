using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosVarios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Llamar para indicar que valores queremos en el array
            //recorridoArray();

            //Llamar para inicializar un array con todos sus valores en 0
            //inicializarArrayEn0();

            //Algoritmo que verifica si hay espacio en el array para insertar un nuevo valor dicho por nosotros previamente.
            //actualizacionArray();

            //Llamar para generar nuevo array
            //generarNuevoArray();

            //Llamar para identificar el valor maximo de un array ya declarado, y en que posición se encuentra.
            //maximo();
            
            //Otra forma de encontrar el maximo en un vector
            //maximo2();



        }

        static void recorridoArray()

        //Estructura repetitiva. Variable se usa como índice del array.
        {
            int i, capArray = 5;
            string linea;
            float[] temperatura = new float[capArray];

            //Recorre el array para asignar el valor de cada posición
            for (i = 0; i < capArray; i++)
            {
                Console.WriteLine("Introduzca el valor a agregar al array");
                linea = Console.ReadLine();
                temperatura[i] = float.Parse(linea);
            }
            //Recorre el array para mostrar el valor de cada posición
            for (i = 0; i < capArray; i++)
            {
                Console.WriteLine("Temperatura:" + temperatura[i]);
            }

            Console.ReadKey();
        }

        static void inicializarArrayEn0()
        {

            int i;
            float[] temperatura = new float[7];
            //Recorre el array para inicializar en cero cada posición
            for (i = 0; i < 7; i++)
            {
                temperatura[i] = 0;
            }

            //mostramos el array generado
            for (i = 0; i < 7; i++)
            {                
                Console.WriteLine(temperatura[i]);
            }

            Console.ReadKey();
        }

        static void actualizacionArray()
        {

            //Actualización de array existente trabajando con un while y verificando que todavía quede lugar para insertar valor.
            int i, pos;
            string[] alumnos = new string[10];
            pos = 0;
            alumnos[0] = "Juan";
            alumnos[1] = "Maria";
            alumnos[2] = "Pedro";
            alumnos[3] = "Ana";
            alumnos[4] = "Lara";

            //Muestro array antes de asignar valor nuevo:
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("[" + i + "]" + alumnos[i]);
            }

            Console.WriteLine("\n");

            while (alumnos[pos] != null && pos < 10)
            {
                pos++;
            }
            if (pos < 10)
            {
                alumnos[pos] = "Jorge";
            }
            else
            {
                Console.WriteLine("Vector completo");
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("[" + i + "]" + alumnos[i]);
            }

            Console.ReadKey();
        }

        static void generarNuevoArray()
        {

            //Consiste en crear un nuevo array, a partir de uno ya existente con alguno de los datos contenidos en el primero, todos o ninguno.

            int[] arrayOriginal = new int[10]; //vector original
            int[] nuevoArray = new int[10]; //vector nuevo
            int i, c; // c-> Variable controladora nuevo vector
            string linea;

            // Primer array, cargar datos:
            for (i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero entero:");
                linea = Console.ReadLine();
                arrayOriginal[i] = int.Parse(linea);
            }

            // Generar nuevo vector
            c = 0; // Inicializar la variable en cero para la 1ra posición
            for (i = 0; i < 10; i++)
            {
                if (arrayOriginal[i] > 0)
                {
                    nuevoArray[c] = arrayOriginal[i];
                    c++; //Se debe incrementar para que cambie de posición//
                }
            }

            // Verificación e informe del nuevo vector
            if (c == 0)
                Console.WriteLine("No se genero el nuevo vector");
            else
            {
                Console.WriteLine("El nuevo vector copiado del original es: ");
                for (i = 0; i < c; i++)
                {
                    Console.Write(nuevoArray[i] + " ");
                }
            }
            Console.ReadKey();
        }

        static void maximo()
        {
            int i, tempMax = 0, posMax = 1;
            int[] temperatura = new int[] { 40, 35, 29, 31, 25, 28 };

            for (i = 0; i < 6; i++)
            {
                if (temperatura[i] > tempMax)
                {
                    tempMax = temperatura[i];
                    posMax = i;
                }
            }

            Console.WriteLine("La temperatura maxima de la semana fue: {0}, en la posición: {1}", tempMax, posMax + 1);

            Console.ReadKey();
        }

        static void maximo2()
        {
            int[] datos = { 10, 15, 31, 0, 0, 6, 11};
            int capacidad = 7; // Capacidad maxima del array
            int i; // Para recorrer los elementos

            //Muestro array:
            for (i = 0; i < capacidad; i++)
            {
                Console.Write(datos[i] + " ");
            }

                // Buscamos el máximo
                int maximo = datos[0];
            for (i = 1; i < capacidad; i++)
            {
                if (datos[i] > maximo)
                    maximo = datos[i];
            }
                
            Console.WriteLine("El máximo es {0} ", maximo);

            Console.ReadKey();
        }

        static void actualizacionBorrarElemento()
        {

            //Si se quiere borrar el dato que hay en una cierta posición, los que estaban a continuación deberán desplazarse "hacia la izquierda" para
            //que no queden huecos.Como en el caso anterior, habrá que actualizar el contador, pero ahora para indicar que queda una posición libre más.

            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; // Número real de datos guardados
            int i; // Para recorrer los elementos

            // Borramos el segundo dato
            Console.WriteLine("Borrando el segundo dato");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
                datos[i] = datos[i + 1];
            cantidad--;
        }

        static void insertarElemento()
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; // Número real de datos guardados
            int i, posicionInsertar;
                   // Insertamos 30 en la tercera posición
            if (cantidad < capacidad)
            {
                Console.WriteLine("Insertando 30 en la posición 3");
                posicionInsertar = 2;
                for (i = cantidad; i > posicionInsertar; i--)
                    datos[i] = datos[i - 1];
                datos[posicionInsertar] = 30;
                cantidad++;

                for (i = 0; i < cantidad; i++)
                    Console.Write("{0} ", datos[i]);
                Console.WriteLine();

                // Buscamos el máximo
                int maximo = datos[0];
                for (i = 1; i < cantidad; i++)
                    if (datos[i] > maximo)
                        maximo = datos[i];
                Console.WriteLine("El máximo es {0} ", maximo);

                // Añadimos un dato al final
                Console.WriteLine("Añadiendo 6 al final");
                if (cantidad < capacidad)
                {
                    datos[cantidad] = 6;
                    cantidad++;
                }

                // Y volvemos a mostrar el array
                for (i = 0; i < cantidad; i++)
                    Console.Write("{0} ", datos[i]);
                Console.WriteLine();

                // Borramos el segundo dato
                Console.WriteLine("Borrando el segundo dato");
                int posicionBorrar = 1;
                for (i = posicionBorrar; i < cantidad - 1; i++)
                    datos[i] = datos[i + 1];
                cantidad--;

                // Y volvemos a mostrar el array
                for (i = 0; i < cantidad; i++)
                    Console.Write("{0} ", datos[i]);
                Console.WriteLine();

                // Insertamos 30 en la tercera posición
                if (cantidad < capacidad)
                {
                    Console.WriteLine("Insertando 30 en la posición 3");
                    posicionInsertar = 2;
                    for (i = cantidad; i > posicionInsertar; i--)
                        datos[i] = datos[i - 1];
                    datos[posicionInsertar] = 30;
                    cantidad++;
                }

                // Y volvemos a mostrar el array
                for (i = 0; i < cantidad; i++)
                    Console.Write("{0} ", datos[i]);
                Console.WriteLine();
            }
        }
        static void algoritmoBusqueda()
        {

            int i = 0, pos = -1, n = 5, elementoBuscado=0;
            int[] array = new int[n];
            while (i < n && pos < 0)
            {
                if (array[i] == elementoBuscado)
                {
                    pos = i;
                }
                i += 1;
            }

            if (pos >= 0)
            {

            }
        }

        static int busqueda2(int [] array, int valor) {

            int i, cap = 10;

            for (i = 0; i < cap; i++)
            {
                if (array[i] == valor)
                {
                    return valor;
                }
            }

            return -1;        
        }

        static void busqueda3(int numSuc, int[] sucursales, float[] totalRecaudado, float dineroRecaudadoDia)
        {
            int cap = 3, k, i;
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

        static void ordenamiento(int[] sucursales, float[] totalRecaudado)
        {
            int i, k, x, capArray=3, aux1;
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

            //informe vector ordenado
            for (i = 0; i < capArray; i++)
            {
                Console.WriteLine("N° Sucursal: " + sucursales[i]);
                Console.WriteLine("Total Recaudado: " + totalRecaudado[i]);
            }
            Console.WriteLine("\n");
        }

        //NO USAR
        //static void bubbleSort(int[] array)
        //{
        //    int i, cap = 5, aux;

        //    for (i = 0; i < cap; i++)
        //    {
        //        for (int j = 0; j < cap - 1 - i; j++)
        //        {
        //            if (array[i] > array[j + 1])
        //            {
        //                aux = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = aux;
        //            }
        //        }
        //    }
        //}
    }
}

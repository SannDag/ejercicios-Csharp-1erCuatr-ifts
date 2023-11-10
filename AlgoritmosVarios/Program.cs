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



        }

        static void recorridoArray()

        //estructura repetitiva. Variable se usa como índice del array.
        {
            int i;
            string linea;
            float[] temperatura = new float[7];

            //Recorre el array para asignar el valor de cada posición
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Introduzca el valo" + i + "del array");
                linea = Console.ReadLine();
                temperatura[i] = float.Parse(linea);
            }
            //Recorre el array para mostrar el valor de cada posición
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("Temperatura:" + temperatura[i]);
            }
        }

        static void inicializar()
        {

            //Consiste en agregar un nuevo elemento al final del array.

            //asignación a cada posición de un valor.

            int i;
            float[] temperatura = new float[7];
            //Recorre el array para inicializar en cero cada posición
            for (i = 0; i < 7; i++)
            {
                temperatura[i] = 0;
            }
        }

        static void actualizacion()
        {
            int i, pos;
            string[] alumnos = new string[10];
            pos = 0;
            alumnos[0] = "Juan";
            alumnos[1] = "Maria";
            alumnos[2] = "Pedro";
            alumnos[3] = "Ana";
            alumnos[4] = "Lara";
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
        }

        static void generarNuevoArray()
        {

            //Consiste en crear un nuevo array, a partir de uno ya existente con alguno de los datos contenidos en el primero, todos o ninguno.

            int[] valores = new int[10]; //vector original
            int[] positivos = new int[10]; //vector nuevo
            int i, c; // c-> Variable controladora nuevo vector
            string linea;
            // Cargar datos
            for (i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero entero:");
                linea = Console.ReadLine();
                valores[i] = int.Parse(linea);
            }
            // Generar nuevo vector
            c = 0; // Inicializar la variable en cero para la 1ra posición
            for (i = 0; i < 10; i++)
            {
                if (valores[i] > 0)
                {
                    positivos[c] = valores[i];
                    c++; //Se debe incrementar para que cambie de posición//
                }
            }

            // Verificación e informe del nuevo vector
            if (c == 0)
                Console.WriteLine("No se genero el nuevo vector");
            else
            {
                Console.WriteLine("El vector de positivos es: ");
                for (i = 0; i < c; i++)
                {
                    Console.WriteLine(positivos[i]);
                }
            }
            Console.ReadKey();
        }

        static void maximoMinimo()
        {

            int capArray = 10;
            int i, tempMax = 0, posMax = 1;
            int[] temperatura = new int[] { 40, 35, 29, 31, 25, 28 };

            for (i = 0; i < capArray - 1; i++)
            {
                if (temperatura[i] > tempMax)
                {
                    tempMax = temperatura[i];
                    posMax = i;
                }
            }

            Console.WriteLine("La temperatura maxima de la semana fue: ", tempMax);

        }

        static void maximoMinimo2()
        {
            int[] datos = { 10, 15, 12, 0, 0 };
            int capacidad = 5; // Capacidad maxima del array
            int cantidad = 3; // Número real de datos guardados
            int i; // Para recorrer los elementos

            // Buscamos el máximo
            int maximo = datos[0];
            for (i = 1; i < cantidad; i++)
                if (datos[i] > maximo)
                    maximo = datos[i];
            Console.WriteLine("El máximo es {0} ", maximo);
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

        static void bubbleSort(int[] array)
        {
            int i, cap = 5, aux;

            for (i = 0; i < cap; i++)
            {
                for (int j = 0; j < cap - 1 - i; j++)
                {
                    if (array[i] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En un depósito se ingresa:
//-código de producto
//-stock (ambos enteros) de los 50 productos almacenados.
//Luego se ingresan los movimientos del día por medio de los siguientes datos:
//-Código de producto
//-Tipo de operación (‘E’: Entrada, ‘S’: Salida)
//-Cantidad
//Este conjunto de datos finaliza al ingresar código 0(inexistente).

//Se pide:
//-Realizar dos operaciones diferentes en las cuales se puedan actualizar el stock y reducir el mismo segun la cantidad ingresada por el usuario.
//Al finalizar el día, emitir un listado con el estado final de cada producto.

namespace StockDeposito_BusquedaSecuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, codigo, cap = 50, cantidad = 0, indice;
            char op;
            int[] cod = new int[cap];
            int[] stock = new int[cap];

            //ingreso datos
            for (i = 0; i < cap; i++)
            {
                Console.WriteLine("Ingrese codigo");
                cod[i] = int.Parse(Console.ReadLine());               

                Console.WriteLine("Ingrese stock");
                stock[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Datos ingresados hasta el momento:");
            Console.WriteLine("Codigos:");
            for (i = 0; i < cap; i++)
            {
                Console.Write(cod[i] + " ");                
            }
            Console.WriteLine("\n ");

            Console.WriteLine("Stock:");
            for (i = 0; i < cap; i++)
            {
                Console.Write(stock[i] + " ");
            }
            Console.WriteLine("\n ");

            // Ingreso del 1er codigo del día
            Console.WriteLine("Ingrese codigo a buscar para modificar stock:");
            codigo = int.Parse(Console.ReadLine());

            //Busqueda del codigo
            while (codigo != 0)
            {

                //imprimo resultado metodo
                Console.WriteLine(busqueda(cod, codigo));
                //buscamos el codigo
                indice = busqueda(cod, codigo);
                if (indice == -1)
                {
                    Console.WriteLine("Codigo inexistente");
                }
                else
                {
                    //Modificaciones si encuentra el elemento
                    Console.WriteLine("Codigo encontrado - Modificaciones:");
                    Console.WriteLine("Ingrese operación a realizar 'e/E: entrada stock' para entrada o 's/S': salida stock");
                    op = char.Parse(Console.ReadLine());

                    if (op == 'e' || op == 'E')
                    {
                        Console.WriteLine("Ingrese cantidad para modificar");
                        cantidad = int.Parse(Console.ReadLine());
                        stock[indice] += cantidad;
                        Console.WriteLine("Stock actualizado con exito, stock anterior: {0}, stock actualizado: {1}", stock[indice] - cantidad, stock[indice]);
                    }
                    else if (op == 's' || op == 'S')
                    {
                        do
                        {
                            Console.WriteLine("Ingrese cantidad para modificar");
                            cantidad = int.Parse(Console.ReadLine());

                            if (stock[indice] >= cantidad)
                            {
                                stock[indice] -= cantidad;
                                Console.WriteLine("Stock actualizado con exito, stock anterior: {0}, stock actualizado: {1}", stock[indice] + cantidad, stock[indice]);
                            }
                            else
                            {
                                Console.WriteLine("Stock insuficiente");
                            }

                            Console.WriteLine("Quiere probar con otra cantidad? Presione s/S o n/N");
                            op = char.Parse(Console.ReadLine());
                        } while(op != 'n' && op != 'N') ;
                    }
                }                

                // Ingreso de los siguientes codigos del día
                Console.WriteLine("Ingrese codigo a buscar o presione 0 para salir");
                codigo = int.Parse(Console.ReadLine());
            }

            
            //Informe de los Vectores
            for (i = 0; i < cap; i++)
            {
                Console.WriteLine("Codigo: " + cod[i] + "Stock: " + stock[i]);
            }
        }

        static int busqueda(int[] cod, int codigo)
        {
            int cap = 3;
            for (int i = 0; i < cap; i++)
            {
                if (cod[i] == codigo)
                {                    
                    return i;
                }
            }
            return -1; // no encontrado        
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)

/*
 6. Realizar el algoritmo (diagrama y codificación) de un programa utilizado para efectuar un estudio en
una biblioteca municipal sobre el préstamo de los siguientes libros:
Codigo Libro   Cantidad en Deposito
1245                240
3287                315
5872                127

Para registrar el mismo, deberán indicarse código de libro y cantidad que desea retirar, sabiendo que
no pueden retirarse más de cinco por préstamo. En caso de que el código sea igual a cero, se
finalizará el ingreso.
Por cada préstamo, deberá solicitarse a la persona su número de documento para saber quién tendrá
posesión de los libros. A su vez, deberá descontarse la cantidad pedida de la cantidad en depósito
para así asegurar la existencia de los libros solicitados. En caso de no encontrarse disponible la
cantidad pedida, deberá informarse en pantalla la siguiente leyenda: “El libro x no dispone de esa
cantidad”. Además, se desea conocer cuántos libros de cada uno fueron prestados y cuál fue el que
menos ejemplares fueron retirados.
Una vez finalizado el ingreso de los datos, deberá generarse un número de préstamo iniciado en 1000
que se incrementará de a uno el cual será informado en pantalla junto con el número de documento de
la persona y código de libro a retirar.
 * */

namespace BibliotecaMunicipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoLibro = 0, cantidadEnDeposito = 0, cantidadARetirar = 0, dniCliente=0, libro1245Prestados=0, libro3287Prestados=0,
                libro5872Prestados=0, numeroPrestamo=999, libroMenosPrestado=0;

            Console.WriteLine("***Inicio solicitud de prestamo***");
            Console.WriteLine("Indique codigo de libro a retirar: ");
            codigoLibro = int.Parse(Console.ReadLine());

            if (codigoLibro == 1245 || codigoLibro == 3287 || codigoLibro == 5872)
            {

                while (codigoLibro != 0)
                {

                    Console.WriteLine("Indique cantidad de libros a retirar: ");
                    cantidadARetirar = int.Parse(Console.ReadLine());

                    switch (codigoLibro)
                    {
                        case 1245:
                            cantidadEnDeposito = 240;

                            if (cantidadARetirar <= 5)
                            {
                                if (cantidadARetirar < cantidadEnDeposito)
                                {
                                    Console.WriteLine("Por favor, ingrese su numero de dni:");
                                    dniCliente = int.Parse(Console.ReadLine());

                                    cantidadEnDeposito -= cantidadARetirar;
                                    libro1245Prestados += cantidadARetirar;
                                    numeroPrestamo++;
                                }
                                else
                                {
                                    Console.WriteLine("El libro con el codigo " + codigoLibro + " no dispone de esa cantidad en stock");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No autorizado - Solo puede retirar hasta 5 libros");
                            }

                            break;

                        case 3287:
                            cantidadEnDeposito = 315;

                            if (cantidadARetirar <= 5)
                            {
                                if (cantidadARetirar < cantidadEnDeposito)
                                {
                                    Console.WriteLine("Por favor, ingrese su numero de dni:");
                                    dniCliente = int.Parse(Console.ReadLine());

                                    cantidadEnDeposito -= cantidadARetirar;
                                    libro3287Prestados += cantidadARetirar;
                                    numeroPrestamo++;
                                }
                                else
                                {
                                    Console.WriteLine("El libro con el codigo " + codigoLibro + "no dispone de esa cantidad en stock");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No autorizado - Solo puede retirar hasta 5 libros");
                            }

                            break;

                        case 5872:
                            cantidadEnDeposito = 127;

                            if (cantidadARetirar <= 5)
                            {
                                if (cantidadARetirar < cantidadEnDeposito)
                                {
                                    Console.WriteLine("Por favor, ingrese su numero de dni:");
                                    dniCliente = int.Parse(Console.ReadLine());

                                    cantidadEnDeposito -= cantidadARetirar;
                                    libro5872Prestados += cantidadARetirar;
                                    numeroPrestamo++;
                                }
                                else
                                {
                                    Console.WriteLine("El libro con el codigo " + codigoLibro + "no dispone de esa cantidad en stock");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No autorizado - Solo puede retirar hasta 5 libros");
                            }

                            break;
                    }

                    if (libro1245Prestados < libro3287Prestados && libro1245Prestados < libro5872Prestados)
                    {
                        libroMenosPrestado += libro1245Prestados;
                    }
                    else if (libro3287Prestados < libro1245Prestados && libro3287Prestados < libro5872Prestados)
                    {
                        libroMenosPrestado += libro3287Prestados;
                    }
                    else if(libro5872Prestados < libro1245Prestados && libro5872Prestados < libro3287Prestados)
                    {
                        libroMenosPrestado += libro5872Prestados;
                    }

                    Console.WriteLine("Numero de prestamo: " + numeroPrestamo + "\nNumero DNI solicitante: " + dniCliente + "\nCodigo libro a retirar: " + codigoLibro);

                    Console.WriteLine("Cantidad de libros con el codigo 1245 prestados: " + libro1245Prestados);
                    Console.WriteLine("Cantidad de libros con el codigo 3287 prestados: " + libro3287Prestados);
                    Console.WriteLine("Cantidad de libros con el codigo 5872 prestados: " + libro5872Prestados);
                    Console.WriteLine("Libro menos prestado " + libroMenosPrestado);

                    Console.WriteLine("Indique codigo de libro a retirar o presione 0 para finalizar: ");
                    codigoLibro = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("El libro con el codigo " + codigoLibro + ", no se encuentra.");
            }

            Console.ReadKey();


        }
    }
}

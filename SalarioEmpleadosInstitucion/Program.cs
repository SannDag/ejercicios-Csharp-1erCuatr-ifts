using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)


/*
 7. Desarrollar un programa (diagrama y codificación) para realizar el cálculo del salario del mes de
diciembre de los empleados de una institución.
Para ello se deberá pedir el ingreso de la siguiente información, siempre y cuando el número de
empleado sea distinto de cero:
 Número de empleado
 Sueldo a pagar
 Bonificación (si/no)
En caso de que reciba bonificación, la misma será de un 20% del sueldo a pagar. Por otro lado,
deberá calcularse el aguinaldo correspondiente al empleado sabiendo que el mismo es medio sueldo a
pagar, sin aplicar la bonificación.
Por cada empleado se debe realizar la siguiente salida en pantalla respetando la distribución de la
información y principalmente la cantidad de decimales, si corresponde: 

    Numero de empleado: XXXXX
    Sueldo a pagar: $XXXXX.XX
    Bonificación: $XXXXX.XX
    Aguinaldo: $XXXXX.XX

    Sueldo total a pagar: $XXXXX.XX

Finalmente, se desea conocer número de empleado y sueldo total a pagar de quien recibe el mayor
sueldo total.
 */

namespace SalarioEmpleadosInstitucion
{
    class Program
    {
        static void Main(string[] args)
        {

            int numEmpleado, empleadoConMayorSueldo = 0;
            float sueldoAPagar, aguinaldo, sueldoTotal = 0, importeBonif = 0, mayorSueldoTotal = 0, band=0;
            string bonificacion;

            Console.WriteLine("Ingrese numero de empleado: ");
            numEmpleado = int.Parse(Console.ReadLine());

            while (numEmpleado != 0) 
            {
                Console.WriteLine("Ingrese sueldo a pagar: ");
                sueldoAPagar = float.Parse(Console.ReadLine());

                Console.WriteLine("Corresponde bonificación (s/n)?");
                bonificacion = Console.ReadLine();

                aguinaldo = sueldoAPagar / 2;

                if (bonificacion.Equals("s"))
                {
                    bonificacion = "Ok";
                    importeBonif = sueldoAPagar * 0.2f;
                    sueldoTotal = sueldoAPagar + importeBonif + aguinaldo;
                }
                else if (bonificacion.Equals("n"))
                {
                    bonificacion = "n/a";
                    importeBonif = 0;
                    sueldoTotal = sueldoAPagar + aguinaldo;
                }

                if (band == 0)
                {
                    mayorSueldoTotal = sueldoTotal;
                    empleadoConMayorSueldo = numEmpleado;
                    band++;
                }
                else if (sueldoTotal > mayorSueldoTotal)                  
                {
                    empleadoConMayorSueldo = numEmpleado;
                    mayorSueldoTotal = sueldoTotal;
                }
                                                

                Console.WriteLine("N° Empleado: " + numEmpleado);
                Console.WriteLine("Sueldo a pagar: " + sueldoAPagar);
                Console.WriteLine("Bonificación: " + bonificacion + " " + importeBonif);
                Console.WriteLine("Aguinaldo: " + aguinaldo);
                Console.WriteLine("Sueldo total: " + sueldoTotal);
                Console.WriteLine("\n Empleado con el mayor sueldo: \n N° empleado: " + empleadoConMayorSueldo + "\n Sueldo:" + mayorSueldoTotal);

                Console.WriteLine("\nIngrese numero de empleado o 0 para finalizar");
                numEmpleado = int.Parse(Console.ReadLine());

            }

            Console.ReadKey();
        }
    }
}

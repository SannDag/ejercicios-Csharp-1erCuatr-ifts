using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 2:
//Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la
//tarde)
//Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
//Imprimir los gastos en sueldos de cada turno.

namespace SueldoEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmpleados = 8;
            double[] sueldos = new double[numEmpleados];
            char[] turnos = new char[numEmpleados];

            for (int i = 0; i < numEmpleados; i++)
            {
                Console.Write("Ingrese el sueldo del empleado {0}: ", i+1);
                sueldos[i] = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el turno del empleado {0} (m/M o t/T): ", i+1);
                turnos[i] = char.Parse(Console.ReadLine());
            }

            // Calcular los gastos en sueldos por turno
            double gastosManana = 0;
            double gastosTarde = 0;

            for (int i = 0; i < numEmpleados; i++)
            {
                if (turnos[i] == 'm' || turnos[i] == 'M')
                {
                    gastosManana += sueldos[i];
                }
                else if (turnos[i] == 't' || turnos[i] == 'T')
                {
                    gastosTarde += sueldos[i];
                }
            }

            // Imprimir los gastos en sueldos por turno
            Console.WriteLine("Gastos en sueldos del turno de la mañana {0}:", gastosManana);
            Console.WriteLine("Gastos en sueldos del turno de la tarde {0}:", gastosTarde);

            Console.ReadKey();
        }
    }
}

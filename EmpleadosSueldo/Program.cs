using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)

/*En una empresa trabajan n empleados cuyos sueldos oscilan entre $10000 y $50000, realizar un
programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre
$10000 y $30000 y cuántos cobran más de $30000. Además, el programa deberá informar el importe
que gasta la empresa en sueldos al personal.*/

namespace EmpleadoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantEmpleados, contadorMayorA30Mil = 0, contadorEntre10y30Mil = 0;
            double sueldo = 0, totalSueldos = 0;

            Console.WriteLine("Informe cantidad de empleados a registrar:");
            cantEmpleados = int.Parse(Console.ReadLine());

            while (cantEmpleados > 0)
            {

                Console.WriteLine("Informe su sueldo por favor:");
                sueldo = double.Parse(Console.ReadLine());

                if (sueldo <= 30000 && sueldo >= 10000)
                {
                    contadorEntre10y30Mil++;
                    totalSueldos += sueldo;
                }
                else if (sueldo > 30000)
                {
                    contadorMayorA30Mil++;
                    totalSueldos += sueldo;
                }

                cantEmpleados--;
                
            }

            Console.WriteLine("Cantidad de empleados que cobran entre $10.000 y $30.000: " + contadorEntre10y30Mil);
            Console.WriteLine("Cantidad de empleados que cobran más de $30.000: " + contadorMayorA30Mil);
            Console.WriteLine("Total importe de sueldos abonados: " + totalSueldos);

            Console.ReadKey();


        }
    }
}

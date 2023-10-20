using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Implementar el Caso de las Matrioskas analizado en Clase.
//Caso base: 1 Matrioska
//Subproblema: Guardar n-1 Matrioskas
//Guardar matrioskas (n)
//if(n > 1)
//Abrir Matrioska n
//Guardar Matrioskas (n-1)
//Colocar n-1 dentro de n
//Cerrar Matrioska n

namespace Matrioskas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese numero de matrioskas a abrir:");
            num = int.Parse(Console.ReadLine());

            guardarMatrioska(num);

            Console.ReadKey();

        }

        static void guardarMatrioska(int n) {

            if (n > 1) {
                Console.WriteLine("Abro matrioska " + n);
                guardarMatrioska(n - 1);
                Console.WriteLine("Guardo matrioska " + (n - 1) + " en matrioska " + n);

            }
        }
    }
}

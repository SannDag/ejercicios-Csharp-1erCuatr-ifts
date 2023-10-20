using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 1: La Torre de Hanoi
//Una antigua leyenda dice que en cierto monasterio de Hanoi había tres postes y que en uno de ellos había 64 discos de tamaño decreciente, uno encima de otro y con el mayor hasta abajo.
//Los monjes del monasterio han estado trabajando sin cesar para llevar los discos desde su poste original hasta algún otro siguiendo una regla sencilla: solamente pueden mover un disco a la vez de un poste a otro, siempre y cuando queda arriba de uno mayor.
//La leyenda indica que el mundo terminará en el momento en que los monjes hayan logrado su propósito…

//Hay que realizar los siguientes movimientos de discos:
//    Del poste 1 al 3
//    Del poste 1 al 2
//    Del poste 3 al 2
//    Del poste 1 al 3
//    Del poste 2 al 1
//    Del poste 2 al 3
//    Del poste 1 al 3

namespace TP1_EJ1_TorresDeHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int discos;

            Console.WriteLine("Ingrese discos para iniciar ejecución del programa: ");
            discos = int.Parse(Console.ReadLine());

            movimiento(discos, 1, 2, 3);


            Console.ReadKey();

        }

        public static void movimiento(int disco, int origen, int auxiliar, int destino)
        {
            if (disco == 1)
            {
                Console.WriteLine("Muevo disco de la torre " + origen + " a la torre " + destino);
            }
            else {

                movimiento(disco - 1, origen, destino, auxiliar);
                Console.WriteLine("Muevo el disco de la torre " + origen + " a la torre " + destino);
                movimiento(disco - 1, auxiliar, origen, destino);                      
            
            }
        }
    }
}

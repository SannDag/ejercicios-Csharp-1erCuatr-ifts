using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio Nº 1:
//Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
//Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más
//bajas.


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            float n = 5, sumaAltura = 0, promedioAltura, contadorAltas=0, contadorBajas=0;
            float[] altura = new float[] { 1.78f, 1.81f, 1.73f, 1.89f, 1.69f };

            for (i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Altura: {0}", altura[i]);
                sumaAltura += altura[i];
                Console.WriteLine("Suma de alturas en proceso: {0}", sumaAltura);
                
            }

            promedioAltura = sumaAltura / n;

            for (i = 0; i < n; i++)
            {
                if (altura[i] > promedioAltura)
                {
                    contadorAltas++;
                }
                else
                {
                    contadorBajas++;
                }                                
            }

            Console.WriteLine("La suma de las alturas es de {0} y el promedio de las alturas es {1}", sumaAltura, promedioAltura);
            Console.WriteLine("Personas mas altas que el promedio: {0}", contadorAltas);
            Console.WriteLine("Personas mas bajas que el promedio: {0}", contadorBajas);            

            Console.ReadKey();
        
        }
    }
}


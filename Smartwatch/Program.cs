using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min)

/*
 8. Para el desarrollo de una aplicación que provee a sus usuarios estadísticas de su salud a partir de la
información generada por un smartwatch, se le ha encargado a usted que desarrolle el procesamiento
de estadísticas.
El reloj informa periódicamente cada 1 minuto los siguientes datos:
● Ritmo cardíaco (Pulsaciones por minuto)
● Cantidad de movimientos registrados por el acelerómetro durante ese minuto. (pasos)
Para los fines del ejercicio, los datos, en lugar de ingresar automáticamente, serán ingresados
manualmente por teclado.
Registre y calcule, minuto a minuto, durante una hora los siguientes datos:
a) Ritmo cardíaco promedio de la hora
Calcule el promedio de todas las mediciones de ritmo cardíaco.
b) Minutos diarios de actividad
Se considera un minuto de actividad si el ritmo cardíaco supera las 100 pulsaciones por minuto o se
registran más de 100 pasos durante ese minuto.
c) Minutos de sueño
Se considera un minuto de sueño si el ritmo cardíaco de ese minuto fue inferior a 90.
d) El ritmo cardíaco máximo registrado y durante qué minuto se registró.
Indique cuál fue el máximo ritmo cardíaco y el minuto en el que fue registrado.
e) Total de pasos en una hora
Total de pasos realizados esa hora.
 */

namespace Smartwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            int pulsaciones, pasos, minutoActividad = 0, minutoSuenio = 0, totalRitmoCardiaco = 0, totalPasos = 0, maxRitmoC = 0, minuto = 0, contador = 0, band = 0;
            double promedioRitmoC;

            for (int i = 1; i < 3; i++)
            {
                contador++;

                Console.WriteLine("Indique pulsaciones");
                pulsaciones = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique pasos");
                pasos = int.Parse(Console.ReadLine());

                totalRitmoCardiaco += pulsaciones;
                totalPasos += pasos;

                if (pulsaciones > 100 || pasos > 100) 
                {
                    minutoActividad++;
                }

                if (pulsaciones < 90) 
                {
                    minutoSuenio++;
                }                

                if (band == 0)
                {
                    maxRitmoC = pulsaciones;
                    minuto = i;
                    band++;
                }
                else if (pulsaciones > maxRitmoC) 
                {
                    maxRitmoC = pulsaciones;
                    minuto = i;
                }
            }

            promedioRitmoC = (double)totalRitmoCardiaco / contador;

            Console.WriteLine("Total promedio ritmo cardiaco: " + promedioRitmoC);
            Console.WriteLine("Valor máximo ritmo cardiaco: \n" + maxRitmoC + " \nen el minuto: \n" + minuto);
            Console.WriteLine("Total de pasos: " + totalPasos);
            Console.WriteLine("Total minutos de sueño: " + minutoSuenio);
            Console.WriteLine("Total minutos de actividad: " + minutoActividad);

            Console.ReadKey();

        }
    }
}

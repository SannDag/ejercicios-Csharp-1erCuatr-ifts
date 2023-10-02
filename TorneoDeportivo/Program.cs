using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)

/*
Realizar el algoritmo y codificar en lenguaje C, un programa para la organización de un torneo
deportivo, que contenga la información correspondiente al número de participante, edad y puntos
obtenidos en una competencia, y que finalice al ingresar número de participante 0 (inexistente).
Dicho programa debe calcular e informar:
a) ¿Cuántos participantes tienen más de 20 años?
b) ¿Cuántos participantes obtuvieron menos de 50 puntos?
c) Total de puntos obtenidos.
d) Número de participante, edad y puntos obtenidos del participante de menor número
 */

namespace TorneoDeportivo
{
    class Program
    {
        static void Main(string[] args)
        {

            int nParticipante = 0, edad, mayoresA20Anios = 0, puntosObtenidos, totalPuntObt = 0, menor50Puntos = 0,
                menorEdadParticipante = 0, menorNumeroParticipante = 0, menorPuntajeParticipante = 0, band=0;

            Console.WriteLine("Ingrese numero de participante a registrar: ");
            nParticipante = int.Parse(Console.ReadLine());

            while(nParticipante != 0) {

                Console.WriteLine("Ingrese edad del participante: ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los puntos obtenidos del participante");
                puntosObtenidos = int.Parse(Console.ReadLine());

                if (edad > 20) {
                    mayoresA20Anios++;                
                }                

                if (puntosObtenidos < 50) {
                    menor50Puntos++;                   
                }

                totalPuntObt += puntosObtenidos;

                if (band == 0)
                {
                    menorNumeroParticipante = nParticipante;
                    menorEdadParticipante = edad;
                    menorPuntajeParticipante = puntosObtenidos;

                    band++;
                }
                else if (nParticipante < menorNumeroParticipante)
                {
                    menorNumeroParticipante = nParticipante;
                    menorEdadParticipante = edad;
                    menorPuntajeParticipante = puntosObtenidos;
                }

                Console.WriteLine("Ingrese numero de participante a registrar o 0 para salir: ");
                nParticipante = int.Parse(Console.ReadLine());              

            }

            Console.WriteLine("Participantes mayores a 20 años: " + mayoresA20Anios);
            Console.WriteLine("Participantes con puntaje menor a 50 puntos:" + menor50Puntos);
            Console.WriteLine("Total de puntos obtenidos de la competencia: " + totalPuntObt);
            Console.WriteLine("Información del participante de menor numeración: \n" + menorNumeroParticipante + "\n" + menorEdadParticipante + "\n" + menorPuntajeParticipante);

            Console.ReadKey();

        }
    }
}

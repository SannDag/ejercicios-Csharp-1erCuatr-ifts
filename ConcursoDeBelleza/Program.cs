using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Restricción: Resolver solo con lo visto en clase hasta ese momento (if, while, switch, for, variable 'band' en un if para captar valores max o min, no arrays, no validaciones)

/*
5.Realizar el algoritmo y codificar en lenguaje C, un programa para la organización de un concurso de
belleza. De las 20 participantes del concurso, se irá registrando los siguientes datos:
Número de participante.
Puntos por inteligencia.
Puntos por cultura general.
Puntos por belleza.
Se necesita informar por pantalla:
-El total de puntos obtenidos entre todas las participantes en cada una de las categorías (total en
inteligencia, total en belleza y total en cultura general).
-Cuántas participantes tiene como menor puntaje en la categoría inteligencia, cuántas en la categoría
cultura general y cuántas en belleza.
- Puntaje total acumulado por todas las participantes en las tres categorías.
- Número de participante y puntaje general, de la concursante de mayor puntaje general.
*/

namespace ConcursoDeBelleza
{
    class Program
    {
        static void Main(string[] args)
        {
            //menorPuntajeCatInteligencia, menorPuntajeCatCulturaG, menorPuntajeCatBelleza

            int nParticipante = 0, contadorParticipanteMenorPuntajeInteligencia=0, contadorParticipanteMenorPuntajeBelleza = 0, contadorParticipanteMenorPuntajeCulturaG = 0,
                participanteMenorPuntajeInteligencia = 0, participanteMenorPuntajeCulturaG = 0, participanteMenorPuntajeBelleza = 0,
                totalPuntajeGeneralEntreCategorias = 0, totalPuntosInteligencia=0, totalPuntosCulturaG = 0, totalPuntosBelleza = 0,
                puntosInteligenciaParticipante = 0, puntosCulturaParticipante = 0, puntosBellezaParticipante = 0,
                participanteMayorPuntajeGeneral = 0, numeroParticipanteMayorPuntajeGeneral=0, band = 0, sumaDeLas3CategoriasXParticipante = 0;


            for (int i = 0; i < 20; i++) {

                Console.WriteLine("Indique numero de participante:");
                nParticipante = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique puntos obtenidos por Inteligencia :");
                puntosInteligenciaParticipante = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique puntos obtenidos por Cultura General :");
                puntosCulturaParticipante = int.Parse(Console.ReadLine());

                Console.WriteLine("Indique puntos obtenidos por Belleza :");
                puntosBellezaParticipante = int.Parse(Console.ReadLine());

                totalPuntosInteligencia += puntosInteligenciaParticipante;
                totalPuntosCulturaG += puntosCulturaParticipante;
                totalPuntosBelleza += puntosBellezaParticipante;

                sumaDeLas3CategoriasXParticipante = puntosInteligenciaParticipante + puntosCulturaParticipante + puntosBellezaParticipante;

                //Cuántas participantes tiene como menor puntaje en la categoría inteligencia, cuántas en la categoría cultura general y cuántas en belleza.

                if (puntosInteligenciaParticipante < puntosCulturaParticipante && puntosInteligenciaParticipante < puntosBellezaParticipante)
                {
                    contadorParticipanteMenorPuntajeInteligencia++;
                }
                else if (puntosBellezaParticipante < puntosInteligenciaParticipante && puntosBellezaParticipante < puntosCulturaParticipante)
                {
                    contadorParticipanteMenorPuntajeBelleza++;
                }
                else if(puntosCulturaParticipante < puntosBellezaParticipante && puntosCulturaParticipante < puntosInteligenciaParticipante)
                {
                    contadorParticipanteMenorPuntajeCulturaG++;
                }

                //Número de participante y puntaje general, de la concursante de mayor puntaje general.
                if (band == 0) {
                    numeroParticipanteMayorPuntajeGeneral = nParticipante;
                    participanteMayorPuntajeGeneral = sumaDeLas3CategoriasXParticipante;

                    band++;
                } else if (sumaDeLas3CategoriasXParticipante > participanteMayorPuntajeGeneral)
                {
                    numeroParticipanteMayorPuntajeGeneral = nParticipante;
                    participanteMayorPuntajeGeneral = sumaDeLas3CategoriasXParticipante;
                }

            }

            //Puntaje total acumulado por todas las participantes en las tres categorías
            totalPuntajeGeneralEntreCategorias = totalPuntosInteligencia + totalPuntosCulturaG + totalPuntosBelleza;

            Console.WriteLine("Puntos total obtenidos por Inteligencia: " + totalPuntosInteligencia);
            Console.WriteLine("Puntos total obtenidos por Cultura general: " + totalPuntosCulturaG);
            Console.WriteLine("Puntos total obtenidos por Belleza: " + totalPuntosBelleza);
            Console.WriteLine("Puntos total obtenidos entre todas las categorías: " + totalPuntajeGeneralEntreCategorias);
            Console.WriteLine("Participante con mayor puntaje general: " + "\n N° participante: " + numeroParticipanteMayorPuntajeGeneral + "\n Puntaje General:" + participanteMayorPuntajeGeneral);
            Console.WriteLine("Cantidad de participantes por categoría con menor puntaje: " + "\n Cat Inteligencia: " + contadorParticipanteMenorPuntajeInteligencia + "\n Cat Cultura G.:" + contadorParticipanteMenorPuntajeCulturaG + "\n Cat Belleza:" + contadorParticipanteMenorPuntajeBelleza);

            Console.ReadKey();
        }
    }
}

using System;

namespace Blackjack
{
    class Program
    {
        /// <summary>
        /// Se solicita dos opcion al jugar para jugar
        /// </summary>
        /// <param name="JugadorValorCartas">Determina el valor de las cartas del jugador</param>
        /// <param name="ComputadoraValorCartas">Es donde se almacenara el valor de la computadora</param>
        
        static void Main(string[] args)
        {

            // TODO 1: El jugador comienza con un conjunto de cartas vacío
            int JugadorValorCartas = 0;
            int ComputadoraValorCartas = 0;

            Random random = new Random();
            //Se despliegan las cartas para el jugador
            JugadorValorCartas += random.Next(1,12); //Numero aleatorio de 1 - 11
            JugadorValorCartas += random.Next(1,12); //Numero aleatorio de 1 - 11

            if(JugadorValorCartas > 21)
            {
                JugadorValorCartas -= 10;
            }

            
            
        }
    }
}

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

            

            // TODO 2: Preguntar al jugador si desea quedarse con las cartas que tiene, o si solicita una carta
            while(true)
            {
                if(JugadorValorCartas == 21)
                {
                    Console.WriteLine("BLACKJACK");
                    break;
                }
                Console.WriteLine("Escribe si para otra carta");
                Console.WriteLine("Escribe no para dejar de pedir cartas");
                Console.WriteLine("Valor de cartas: " + JugadorValorCartas.ToString() + ", otra carta?");
                 
                string respuesta = Console.ReadLine();

                if(respuesta == "si")
                {
                    // TODO 3: Si el jugador solicita una carta, generar aleatoriamente una carta de una baraja y agregarla a las cartas que tiene el jugador.
                    JugadorValorCartas += random.Next(1,12); 

                    if(JugadorValorCartas > 21)
                    {
                        Console.WriteLine("Excediste");
                        break;
                    }
                    
                }

                else if (respuesta == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta, intenta de nuevo");
                    continue;
                }
            }

             
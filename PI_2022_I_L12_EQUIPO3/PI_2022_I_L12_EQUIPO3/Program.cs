using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L12_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12 - Escriba un programa que juegue a “adivina el número” de la siguiente
                   manera: su programa elige el número a adivinar, seleccionando un entero
                   aleatorio en el rango de 1 a 1000.Si la respuesta del jugador es incorrecta,
                   su programa deberá iterar hasta que el jugador adivine correctamente.Su
                   programa deberá seguir indicando al jugador los mensajes Demasiado
                   alto o bajo, para ayudar a que el jugador “se acerque” a la respuesta
                   correcta.Si la respuesta es correcta deberá mostrar el siguiente mensaje
                   ¡Excelente! ¡Adivinaste el número!*/

            int numero, azar;
            Random r = new Random();
            azar = r.Next(1, 1001);
            bool continuar = true;
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("Adivina el numero");
                        numero = int.Parse(Console.ReadLine());
                        if (numero < azar)
                        {
                            Console.WriteLine($"Demasiado bajo");
                        }
                        else if (numero > azar)
                        {
                            Console.WriteLine($"Demasiado alto");
                        }
                    } while (numero != azar);
                    Console.WriteLine($"¡Excelente! ¡Adivinaste el número!");
                    continuar = false;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deberia ingresa un valor numerico");

                }
            } while (continuar);

            Console.ReadLine();
        }

    }
}


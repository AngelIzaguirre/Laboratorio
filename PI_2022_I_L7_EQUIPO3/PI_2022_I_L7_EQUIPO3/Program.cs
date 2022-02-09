using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L7_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7 - Haga un programa que diga si el carácter ingresado es Vocal o No es Vocal.*/
            char vocal;
            bool continuar = true;
            do
            {
                try
                {

                    Console.WriteLine("Ingrese un caracter");
                    vocal = char.Parse(Console.ReadLine());
                    vocal = vocal.ToString().ToUpper().ToCharArray()[0];
                    if ((vocal == 'A') || (vocal == 'E') || (vocal == 'I') || (vocal == 'O') || (vocal == 'U'))
                    {
                        Console.WriteLine($"Es Vocal");
                    }
                    else
                    {
                        Console.WriteLine($"No es Vocal");
                    }
                    continuar = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deberias de ingresar un valor numerico");
                }

            } while (continuar);
            Console.ReadLine();
        }
    }
}

    


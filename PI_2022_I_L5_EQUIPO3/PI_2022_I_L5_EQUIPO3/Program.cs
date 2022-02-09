using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L5_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5- Haga un programa que diga la cantidad de cifras si es mayor a 0 y menor
              a 10 dirá uno, si es mayor o igual a 10 y menor a 100 mostrará dos, si es
              mayor o igual a 100 o menor a 1000 mostrará tres, si es mayor o igual a
              1000 y menor a 10000 mostrará 4, caso contrario mostrará mayor a 5.*/

            int numero;
            bool continuar = true;
            do
            {
                try
                {

                    Console.WriteLine("Ingrese un numero");
                    numero = int.Parse(Console.ReadLine());
                    if ((numero > 0) && (numero < 10))
                    {
                        Console.WriteLine($"Uno");
                    }
                    else if ((numero >= 10) && (numero < 100))
                    {
                        Console.WriteLine($"dos");
                    }
                    else if ((numero >= 100) && (numero < 1000))
                    {
                        Console.WriteLine($"tres");
                    }
                    else if ((numero >= 1000) && (numero < 10000))
                    {
                        Console.WriteLine($"4");
                    }
                    else
                    {
                        Console.WriteLine($"Mayor a 5");
                    }
                    continuar = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Deverias ingrresar un valor numerico");
                }
            } while (continuar);
            Console.ReadLine();
        }


    }
}


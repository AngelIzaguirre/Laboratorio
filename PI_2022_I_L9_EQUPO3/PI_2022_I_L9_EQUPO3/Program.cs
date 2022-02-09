using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L9_EQUPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9 - Haga un programa que de acuerdo al salario calculará el aumento
                  De 0 a 4999 aumentará 20 %
                  De 5000 a 9999 aumentará 10 %
                  De 10000 a 14999 aumentará 5 %
                  De 15000 adelante 3 %*/
            int sueldo;
            double aumento;
            bool continuar = true;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese su sueldo");
                    sueldo = int.Parse(Console.ReadLine());
                    if ((sueldo >= 0) && (sueldo <= 4999))
                    {
                        aumento = (sueldo * 0.20);
                        Console.WriteLine($"El aumento es de: {aumento}");
                    }
                    else if ((sueldo >= 5000) && (sueldo <= 9999))
                    {
                        aumento = (sueldo * 0.10);
                        Console.WriteLine($"El aumento es de: {aumento}");
                    }
                    else if ((sueldo >= 10000) && (sueldo <= 14999))
                    {
                        aumento = (sueldo * 0.05);
                        Console.WriteLine($"El aumento es de: {aumento}");
                    }
                    else
                    {
                        aumento = (sueldo * 0.03);
                        Console.WriteLine($"El aumento es de: {aumento}");
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


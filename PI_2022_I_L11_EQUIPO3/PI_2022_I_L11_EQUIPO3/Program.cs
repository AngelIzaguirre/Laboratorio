using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L11_EQUIPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11 - Haga un programa para promediar 3 notas, si el estudiante promedia
                 menos de 70 Reprueba, si es menor o igual a 80 bueno, si es menor o 
                 igual a 90 muy bueno, si es menor o igual a 100 sobresaliente, caso
                 contrario error.Resuelvalo con switch.*/
            bool continuar = true;
            do
            {
                try
                {
                    int nota1, nota2, nota3, caso;
                    decimal promedio;
                    Console.WriteLine("Ingrese la nota 1");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota 2");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la nota 3");
                    nota3 = int.Parse(Console.ReadLine());
                    promedio = (nota1 + nota2 + nota3) / 3;
                    if (promedio < 70)
                    {
                        caso = 1;
                    }
                    else if ((promedio >= 70) && (promedio <= 80))
                    {
                        caso = 2;
                    }
                    else if ((promedio > 80) && (promedio <= 90))
                    {
                        caso = 3;
                    }
                    else
                    {
                        caso = 4;
                    }
                    switch (caso)
                    {
                        case 1: Console.WriteLine($"Desafortunamente el estudiante a= Reprobado y su promedio es de= {promedio} puntos"); break;
                        case 2: Console.WriteLine($"El estudiante aprobo con un desempeño= Bueno y su promedio es de= {promedio} puntos"); break;
                        case 3: Console.WriteLine($"El estudiante aprobo con un desempeño= Muy Bueno y su promedio es de= {promedio} puntos"); break;
                        case 4: Console.WriteLine($"El estudiante aprobo con un desempeño= Sobresaliente y su promedio es de= {promedio} puntos"); break;
                        default: Console.WriteLine("Error"); break;
                    }
                    Console.ReadLine();
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
    


